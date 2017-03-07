using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Remote.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace Avalonia.Remote.Transport
{
    public class BsonStreamTransport : IAvaloniaRemoteTransport
    {
        private readonly IMessageTypeResolver _resolver;
        private readonly Stream _inputStream;
        private readonly Stream _outputStream;
        private readonly CancellationToken _cancel;
        private readonly MemoryStream _outputBlock = new MemoryStream();
        private readonly object _lock = new object();
        private bool _writeOperationPending;
        private bool _readingAlreadyStarted;
        private bool _writerIsBroken;
        static readonly JsonSerializer Serializer = new JsonSerializer();

        public BsonStreamTransport(IMessageTypeResolver resolver, Stream inputStream, Stream outputStream,
            CancellationToken cancel)
        {
            _resolver = resolver;
            _inputStream = inputStream;
            _outputStream = outputStream;
            _cancel = cancel;
        }

        public void StartReading()
        {
            lock (_lock)
            {
                if(_readingAlreadyStarted)
                    throw new InvalidOperationException("Reading has already started");
                _readingAlreadyStarted = true;
                Task.Run(Reader, _cancel);
                
            }
        }

        async Task ReadExact(byte[] buffer)
        {
            int read = 0;
            while (read != buffer.Length)
            {
                var readNow =  await _inputStream.ReadAsync(buffer, read, buffer.Length - read, _cancel);
                if (readNow == 0)
                    throw new EndOfStreamException();
                read += readNow;
            }
        }

        async Task Reader()
        {
            try
            {
                var reader = new BinaryReader(_inputStream);
                while (true)
                {
                    var infoBlock = new byte[20];
                    await ReadExact(infoBlock);
                    var length = BitConverter.ToInt32(infoBlock, 0);
                    var guidBytes = new byte[16];
                    Buffer.BlockCopy(infoBlock, 4, guidBytes, 0, 16);
                    var guid = new Guid(guidBytes);
                    var buffer = new byte[length];
                    await ReadExact(buffer);
                    var message = Serializer.Deserialize(new BsonReader(new MemoryStream(buffer)), _resolver.GetByGuid(guid));
                    OnMessage?.Invoke(message);
                }
            }
            catch (Exception e)
            {
                FireException(e);
                return;
            }
        }

        private static readonly byte[] ZeroLength = new byte[4];

        public async Task Send(object data)
        {
            lock (_lock)
            {
                if(_writerIsBroken) //Ignore further calls, since there is no point of writing to "broken" stream
                    return;
                if (_writeOperationPending)
                    throw new InvalidOperationException("Previous send operation was not finished");
                _writeOperationPending = true;
            }
            try
            {
                var guid = _resolver.GetGuid(data.GetType()).ToByteArray();
                _outputBlock.Seek(0, SeekOrigin.Begin);
                _outputBlock.SetLength(0);
                _outputBlock.Write(ZeroLength, 0, 4);
                _outputBlock.Write(guid, 0, guid.Length);
                var writer = new BsonWriter(_outputBlock);
                Serializer.Serialize(writer, data);
                _outputBlock.Seek(16, SeekOrigin.Begin);
                var length = BitConverter.GetBytes(_outputBlock.Length - 20);
                _outputBlock.Write(length, 0, length.Length);
                _outputBlock.Seek(0, SeekOrigin.Begin);

                try
                {
                    await _outputBlock.CopyToAsync(_outputStream, 0x1000, _cancel);
                }
                catch (Exception e) //We are only catching "network"-related exceptions here
                {
                    lock (_lock)
                    {
                        _writerIsBroken = true;
                    }
                    FireException(e);
                }
            }
            finally
            {
                lock (_lock)
                {
                    _writeOperationPending = false;
                }
            }
        }

        void FireException(Exception e)
        {
            var cancel = e as OperationCanceledException;
            if (cancel?.CancellationToken == _cancel)
                return;
            OnException?.Invoke(e);
        }

        public event Action<object> OnMessage;
        public event Action<Exception> OnException;
    }
}

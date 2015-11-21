using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive.Disposables;
using System.Text;
using System.Threading;
using Perspex.Platform;

namespace Perspex.Shared.PlatformSupport
{
    abstract class MobileThreadingInterface : IPlatformThreadingInterface
    {
        public void RunLoop(CancellationToken cancellationToken)
        {
        }

        public IDisposable StartTimer(TimeSpan interval, Action tick)
        {
            var st = Stopwatch.StartNew();
            var lastTime = new TimeSpan();
            var tps = 0;



            if (interval.TotalMilliseconds < 10)
                interval = TimeSpan.FromMilliseconds(10);
            object l = new object();
            var stopped = false;
            Timer timer = null;
            var scheduled = false;
            timer = new Timer(_ =>
            {
                lock (l)
                {
                    if (stopped)
                    {
                        timer.Dispose();
                        return;
                    }
                    if (scheduled)
                        return;
                    scheduled = true;
                    PostOnMainThread(() =>
                    {
                        tps++;
                        var now = st.Elapsed;
                        var elapsed = now - lastTime;
                        if (elapsed.TotalSeconds > 1)
                        {
                            Debug.WriteLine("TPS: " + tps / elapsed.TotalSeconds);
                            tps = 0;
                            lastTime = now;
                        }

                        tick();
                        lock (l)
                        {
                            scheduled = false;
                        }
                    });
                }
            }, null, TimeSpan.Zero, interval);

            return Disposable.Create(() =>
            {
                lock (l)
                {
                    stopped = true;
                    timer.Dispose();
                }
            });
        }

        protected abstract void PostOnMainThread(Action action);

        public void Signal()
        {
            PostOnMainThread(() => Signaled?.Invoke());
        }

        public abstract bool CurrentThreadIsLoopThread { get; }
        public event Action Signaled;
    }
}

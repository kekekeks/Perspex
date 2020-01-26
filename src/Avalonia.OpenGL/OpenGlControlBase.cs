using System;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Logging;
using Avalonia.Media;
using Avalonia.OpenGL.Imaging;
using static Avalonia.OpenGL.GlConsts;

namespace Avalonia.OpenGL
{
    public abstract class OpenGlControlBase : Control
    {
        private IGlContext _context;
        private int _fb, _texture, _renderBuffer;
        private OpenGlTextureBitmap _bitmap;
        private Size _oldSize;
        protected GlDisplayType DisplayType { get; private set; }
        public sealed override void Render(DrawingContext context)
        {
            if(!EnsureInitialized())
                return;
            using (_context.MakeCurrent())
            {
                using (_bitmap.Lock())
                {
                    var gl = _context.Display.GlInterface;
                    gl.BindFramebuffer(GL_FRAMEBUFFER, _fb);
                    if (_oldSize != Bounds.Size)
                        ResizeTexture(gl);

                    OnOpenGlRender(gl, _fb);
                    gl.Flush();
                }
            }

            context.DrawImage(_bitmap, 1, new Rect(_bitmap.Size), Bounds);
            base.Render(context);
        }

        protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
        {
            if (_context != null)
            {
                using (_context.MakeCurrent())
                {
                    OnOpenGlDeinit(_context.Display.GlInterface, _fb);
                    var gl = _context.Display.GlInterface;
                    gl.BindTexture(GL_TEXTURE_2D, 0);
                    gl.BindFramebuffer(GL_FRAMEBUFFER, 0);
                    gl.DeleteFramebuffers(1, new[] { _fb });
                    using (_bitmap.Lock())
                    {
                        _bitmap.SetTexture(0, 0, new PixelSize(1, 1), 1);
                        gl.DeleteTextures(1, new[] { _texture });
                    }
                    _bitmap.Dispose();
                    
                    _context.Dispose();
                    _context = null;
                }
            }
            base.OnDetachedFromVisualTree(e);
        }

        bool EnsureInitialized()
        {
            if (_context != null)
                return true;
            
            var feature = AvaloniaLocator.Current.GetService<IWindowingPlatformGlFeature>();
            if (feature == null)
                return false;
            _context = feature.CreateContext();
            DisplayType = feature.Display.Type;
            try
            {
                _bitmap = new OpenGlTextureBitmap();
            }
            catch (PlatformNotSupportedException)
            {
                _context.Dispose();
                _context = null;
                return false;
            }

            using (_context.MakeCurrent())
            {
                _oldSize = Bounds.Size;
                var gl = _context.Display.GlInterface;
                gl.Enable(GL_DEBUG_OUTPUT_SYNCHRONOUS);
                gl.DebugMessageCallback?.Invoke(OnDebugMessage, IntPtr.Zero);
                gl.DebugMessageControl?.Invoke(GL_DONT_CARE, GL_DONT_CARE, GL_DONT_CARE, 0, null, true);
                var oneArr = new int[1];
                gl.GenFramebuffers(1, oneArr);
                _fb = oneArr[0];
                gl.BindFramebuffer(GL_FRAMEBUFFER, _fb);

                gl.GenTextures(1, oneArr);
                _texture = oneArr[0];
                gl.BindTexture(GL_TEXTURE_2D, _texture);
                ResizeTexture(gl);

                gl.FramebufferTexture2D(GL_FRAMEBUFFER, GL_COLOR_ATTACHMENT0, GL_TEXTURE_2D, _texture, 0);

                var status = gl.CheckFramebufferStatus(GL_FRAMEBUFFER);
                if (status != GL_FRAMEBUFFER_COMPLETE)
                {
                    //TODO: Cleanup
                    return false;
                }
                OnOpenGlInit(_context.Display.GlInterface, _fb);
            }

            return true;
        }

        static void OnDebugMessage(int source, int type, int id, int severity, int length, IntPtr message, IntPtr userParam)
        {
            var err = Marshal.PtrToStringAnsi(message, length);
            Console.WriteLine(err);
        }

        private bool HasError(GlInterface gl)
        {
            int err;
            var rv = false;
            while ((err = gl.GetError()) != GL_NO_ERROR)
            {
                Logger.TryGet(LogEventLevel.Error)?.Log("OpenGL", "OpenGLControlBase", "Error: ", err);
                rv = true;
            }

            return rv;
        }

        bool ResizeTexture(GlInterface gl)
        {
            int internalFormat = _context.Display.Type == GlDisplayType.OpenGLES ? GL_RGBA : GL_RGBA4;
            var size = GetPixelSize();
            gl.TexImage2D(GL_TEXTURE_2D, 0, internalFormat,
                size.Width, size.Height, 0, GL_RGBA, GL_UNSIGNED_BYTE, IntPtr.Zero);
            gl.TexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);
            gl.TexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
            if (HasError(gl))
                return false;

            var oldRenderBuffer = _renderBuffer;
            //TODO: destroy the previous one
            var oneArr = new int[1];
            gl.GenRenderbuffers(1, oneArr);
            _renderBuffer = oneArr[0];
            gl.BindRenderbuffer(GL_RENDERBUFFER, _renderBuffer);

            if (HasError(gl))
                return false;

            var depthFormat = _context.Display.Type == GlDisplayType.OpenGLES ?
                GL_DEPTH_COMPONENT16 :
                GL_DEPTH_COMPONENT;

            gl.RenderbufferStorage(GL_RENDERBUFFER, depthFormat, size.Width, size.Height);

            HasError(gl);
            /*if (HasError(gl))
                return false;
*/
            gl.FramebufferRenderbuffer(GL_FRAMEBUFFER, GL_DEPTH_ATTACHMENT, GL_RENDERBUFFER, _renderBuffer);

            if (HasError(gl))
                return false;
            using (_bitmap.Lock())
                _bitmap.SetTexture(_texture, GL_RGBA, size, 1);
                //_bitmap.SetTexture(_texture, internalFormat, size, 1);
            return true;
        }
        
        //TODO: dpi
        PixelSize GetPixelSize() =>
            new PixelSize(Math.Max(1, (int)Bounds.Width),
                Math.Max(1, (int)Bounds.Height));


        protected virtual void OnOpenGlInit(GlInterface gl, int fb)
        {
            
        }

        protected virtual void OnOpenGlDeinit(GlInterface gl, int fb)
        {
            
        }
        
        protected abstract void OnOpenGlRender(GlInterface gl, int fb);
    }
}

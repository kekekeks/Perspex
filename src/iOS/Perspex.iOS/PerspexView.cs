using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using Perspex.Controls.Platform;
using Perspex.Input;
using Perspex.Input.Raw;
using Perspex.Media;
using Perspex.Platform;
using UIKit;

namespace Perspex.iOS
{
    class PerspexView : UIView, IWindowImpl
    {
        private readonly UIWindow _window;
        private readonly UIViewController _controller;
        CAEAGLLayer _layer = new CAEAGLLayer();
        private IInputRoot _inputRoot;

        public PerspexView(UIWindow window, UIViewController controller)
        {
            if (controller == null) throw new ArgumentNullException(nameof(controller));
            _window = window;
            _controller = controller;
            AutoresizingMask = UIViewAutoresizing.All;
            Layer.AddSublayer(_layer);
            Handle = new LayerHandle(_layer);
            AutoFit();
            UIApplication.Notifications.ObserveDidChangeStatusBarOrientation(delegate { AutoFit(); });
            UIApplication.Notifications.ObserveDidChangeStatusBarFrame(delegate { AutoFit(); });
        }


        void AutoFit()
        {
            var needFlip = !UIDevice.CurrentDevice.CheckSystemVersion(8, 0) &&
                           (_controller.InterfaceOrientation == UIInterfaceOrientation.LandscapeLeft
                            || _controller.InterfaceOrientation == UIInterfaceOrientation.LandscapeRight);

            var frame = UIScreen.MainScreen.Bounds;
            if (needFlip)
                Frame = new CGRect(frame.Y, frame.X, frame.Height, frame.Width);
            else
                Frame = frame;
        }

        public Action Activated { get; set; }
        public Action Closed { get; set; }
        public Action Deactivated { get; set; }
        public Action<RawInputEventArgs> Input { get; set; }
        public Action<Rect> Paint { get; set; }
        public Action<Size> Resized { get; set; }
        
        class LayerHandle : IPlatformHandle
        {
            private readonly CAEAGLLayer _layer;

            public LayerHandle(CAEAGLLayer layer)
            {
                _layer = layer;
            }
            //This view is a singleton, so it's safe call CFBridgingRetain every time
            public IntPtr Handle => _layer.DangerousRetain().Handle;
            public string HandleDescriptor => "Layer";
        }
        public IPlatformHandle Handle { get; private set; }


        public override void LayoutSubviews() => Resized?.Invoke(ClientSize);

        public Size ClientSize
        {
            get { return Bounds.Size.ToPerspex(); }
            set { Resized?.Invoke(ClientSize); }
        }

        public void Activate()
        {
        }
        static readonly Stopwatch St = Stopwatch.StartNew();
        public override void Draw(CGRect rect)
        {
            DoDraw();
        }

        bool _invalidationRequested;
        int _frames = 0;
        TimeSpan _lastMeasure;
        void DoDraw()
        {
            _invalidationRequested = false;
            Debug.WriteLine("Render started " + St.Elapsed);
            _layer.Bounds = new CGRect(0, 0, Bounds.Width, Bounds.Height);
            var st = Stopwatch.StartNew();
            Paint?.Invoke(new Rect(new Point(), ClientSize));
            Debug.WriteLine("Render took " + st.Elapsed);

            _frames++;
            var now = St.Elapsed;
            var elapsed = (now - _lastMeasure).TotalSeconds;
            if (elapsed > 1)
            {
                Debug.WriteLine("FPS: " + _frames/elapsed);
                _frames = 0;
                _lastMeasure = now;
            }
        }

        public void Invalidate(Rect rect)
        {
            Debug.WriteLine("Invalidation requested at " + St.Elapsed);
            if (_invalidationRequested)
                return;
            _invalidationRequested = true;
            BeginInvokeOnMainThread(DoDraw);
        } 

        public void SetInputRoot(IInputRoot inputRoot) => _inputRoot = inputRoot;

        public Point PointToScreen(Point point) => point;

        public void SetCursor(IPlatformHandle cursor)
        {
            //Not supported
        }

        public void Show()
        {
        }

        public Size MaxClientSize => Bounds.Size.ToPerspex();
        public void SetTitle(string title)
        {
            //Not supported
        }

        public IDisposable ShowDialog()
        {
            //Not supported
            return Disposable.Empty;
        }

        public void Hide()
        {
            //Not supported
        }

        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            var touch = touches.AnyObject as UITouch;
            if (touch != null)
            {
                var location = touch.LocationInView(this).ToPerspex();

                Input?.Invoke(new RawMouseEventArgs(
                    PerspexAppDelegate.MouseDevice,
                    (uint) touch.Timestamp,
                    _inputRoot,
                    RawMouseEventType.LeftButtonUp,
                    location,
                    InputModifiers.None));
            }
        }

        Point _touchLastPoint;
        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            var touch = touches.AnyObject as UITouch;
            if (touch != null)
            {
                var location = touch.LocationInView(this).ToPerspex();
                _touchLastPoint = location;
                Input?.Invoke(new RawMouseEventArgs(PerspexAppDelegate.MouseDevice, (uint) touch.Timestamp, _inputRoot,
                    RawMouseEventType.Move, location, InputModifiers.None));

                Input?.Invoke(new RawMouseEventArgs(PerspexAppDelegate.MouseDevice, (uint) touch.Timestamp, _inputRoot,
                    RawMouseEventType.LeftButtonDown, location, InputModifiers.None));
            }
        }

        public override void TouchesMoved(NSSet touches, UIEvent evt)
        {
            var touch = touches.AnyObject as UITouch;
            if (touch != null)
            {
                var location = touch.LocationInView(this).ToPerspex();
                if (PerspexAppDelegate.MouseDevice.Captured != null)
                    Input?.Invoke(new RawMouseEventArgs(PerspexAppDelegate.MouseDevice, (uint) touch.Timestamp, _inputRoot,
                        RawMouseEventType.Move, location, InputModifiers.LeftMouseButton));
                else
                {
                    Input?.Invoke(new RawMouseWheelEventArgs(PerspexAppDelegate.MouseDevice, (uint) touch.Timestamp,
                        _inputRoot, location, location - _touchLastPoint, InputModifiers.LeftMouseButton));
                }
                _touchLastPoint = location;
            }
        }
    }

    class PerspexViewController : UIViewController
    {
        public PerspexView PerspexView { get; }

        public PerspexViewController(UIWindow window)
        {
            PerspexView = new PerspexView(window, this);
        }

        public override void LoadView()
        {
            View = PerspexView;
        }
    }
}

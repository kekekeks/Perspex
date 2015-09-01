using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using Perspex.Controls;
using Perspex.Direct2D1;
using Perspex.Input;
using Perspex.Input.Raw;
using Perspex.Platform;
using Perspex.Themes.Default;
using Perspex.Win32;
using Perspex.Win32.Interop;
using Splat;

namespace Perspex.DesignerSupport
{
    public class VirtualPlatform : Application
    {
        public static VirtualPlatform Instance { get; private set; }
        public static void Initialize()
        {
            if(Instance != null)
                return;
            Instance = new VirtualPlatform();
            Locator.CurrentMutable.Register(() => new DesignerWindowImpl(), typeof(IWindowImpl));
            Win32Platform.Initialize(true);
            Direct2D1Platform.Initialize();
            
        }

        public VirtualPlatform()
        {
            this.RegisterServices();
            this.Styles = new DefaultTheme();
        }
        
    }

    public class DesignerWindowImpl : WindowImpl
    {
        public HwndHost Host { get; set; }

        class FakeHost : HwndHost
        {
            private readonly IntPtr _hWnd;

            public FakeHost(IntPtr hWnd)
            {
                _hWnd = hWnd;
            }

            protected override HandleRef BuildWindowCore(HandleRef hwndParent)
            {
                UnmanagedMethods.SetParent(_hWnd, hwndParent.Handle);
                return new HandleRef(this, _hWnd);
            }

            protected override void DestroyWindowCore(HandleRef hwnd)
            {
            }
        }

        private static readonly System.Windows.Forms.UserControl WinFormsControl = new System.Windows.Forms.UserControl();

        protected override IntPtr CreateWindowOverride(ushort atom)
        {
            var hWnd = UnmanagedMethods.CreateWindowEx(
                0,
                atom,
                null,
                (int) UnmanagedMethods.WindowStyles.WS_CHILD,
                UnmanagedMethods.CW_USEDEFAULT,
                UnmanagedMethods.CW_USEDEFAULT,
                UnmanagedMethods.CW_USEDEFAULT,
                UnmanagedMethods.CW_USEDEFAULT,
                WinFormsControl.Handle,
                IntPtr.Zero,
                IntPtr.Zero,
                IntPtr.Zero);
            Host = new FakeHost(hWnd);
            return hWnd;
        }
    }
}

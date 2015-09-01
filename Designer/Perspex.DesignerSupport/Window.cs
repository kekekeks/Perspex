using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Interop;
using System.Windows.Markup;

namespace Perspex.DesignerSupport
{
    [ContentProperty("WpfContent")]
    partial class Window : TopLevel
    {
        private object _wpfContent;

        static Window()
        {
            VirtualPlatform.Initialize();
        }


        public object WpfContent
        {
            get { return _wpfContent; }
            set
            {
                _wpfContent = value;
                _base.Content = ((IWpfWrapper)value).PerspexObject;
            }
        }

        public Window()
        {
            _base.Show();
            
        }

        protected override HwndHost GetControl()
        {
            return ((DesignerWindowImpl) _base.PlatformImpl).Host;
        }
    }


    public abstract class TopLevel : System.Windows.Controls.ContentControl
    {
        protected abstract HwndHost GetControl();


        protected TopLevel()
        {
            Content = GetControl();
            
        }
    }
}

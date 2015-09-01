using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;
using Perspex.DesignerSupport;
using Perspex.Input;
using Perspex.Win32;

namespace DesignerTestApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (var xread = new StreamReader(new AssetLoader().Open(new Uri("MainWindow.xaml", UriKind.Relative))))
            {
                var xamp = xread.ReadToEnd();
                Console.WriteLine(typeof (Perspex.DesignerSupport.Window));
                var root = XamlReader.Parse(xamp);
                
                var window = new System.Windows.Window() { Content = root, Background = Brushes.Black };
                
                new System.Windows.Application().Run(window);
                Console.WriteLine(root);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perspex.Controls;
using Perspex.DesignerSupport.Generator.CodeDom;
using Perspex.Platform;

namespace Perspex.DesignerSupport.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new StringWriter();
            var g = new LineGenerator(writer, 0);
            g.WriteLine("namespace Perspex.DesignerSupport").Block(ns =>
            {
                foreach (
                    var type in typeof (Grid).Assembly.GetTypes().Where(t => typeof (PerspexObject).IsAssignableFrom(t))
                    )
                {
                    if (!type.IsAbstract)
                        GenerateControl(type).Generate(ns);
                }
            });
            File.WriteAllText(@"..\..\..\Perspex.DesignerSupport\Controls.generated.cs", writer.ToString());
        }

        static string GetFullTypeName(Type type)
        {
            if (type.IsGenericType && !type.IsGenericTypeDefinition)
            {
                var gen = type.GetGenericTypeDefinition();
                return GetFullTypeName(gen) + "<" +
                       string.Join(", ", type.GetGenericArguments().Select(GetFullTypeName)) + ">";
            }
            var name = type.Namespace + "." + type.Name;
            var gt = name.IndexOf("`");
            if (gt != -1)
                name = name.Substring(0, gt);
            return name;
        }

        private static Class GenerateControl(Type type)
        {
            var cl = new Class(type.Name);
            
            cl.Interfaces.Add("IWpfWrapper");
            cl.Properties.Add(new Property("PerspexObject", "object")
            {
                Get = "return _base;"
            });
            cl.Fields.Add(new Field("_base", GetFullTypeName(type)) {Initializer = $"new {type.FullName}()"});

            if (type != typeof (Window))
            {
                cl.Attributes.Add(new ClassAttribute("System.Windows.Markup.ContentProperty", "\"WpfChildren\""));
                cl.Fields.Add(new Field("WpfChildren", "System.Collections.ObjectModel.ObservableCollection<object>")
                {
                    IsAutoProperty = true,
                    Initializer = "new System.Collections.ObjectModel.ObservableCollection<object>()"
                });
            }

            var known = new HashSet<string>();
            foreach (var prop in type.GetProperties())
            {
                if (!known.Add(prop.Name))
                    continue;
                if (prop.GetIndexParameters()?.Length > 0)
                    continue;
                if (prop.PropertyType == typeof (ITopLevelImpl))
                    continue;
                if (prop.Name == "DependencyResolver")
                    continue;

                var p = new Property(prop.Name, GetFullTypeName(prop.PropertyType));
                if (prop.SetMethod?.IsPublic == true)
                    p.Set = $"_base.{prop.Name} = value;";
                p.Get = $"return _base.{prop.Name};";
                cl.Properties.Add(p);
            }
            return cl;

        }
    }
}

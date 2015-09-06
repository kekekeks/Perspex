using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Windows.Design.Metadata;
using Perspex.Animation;
using Perspex.Controls;
using Perspex.Markup.Xaml.Metadata.CodeDom;
using Perspex.Platform;

namespace Perspex.Markup.Xaml.Metadata
{
    class Program
    {
        private static readonly List<Assembly> DefaultImports = new[]
        {
            typeof (AttributeTable).Assembly,
            typeof (System.Windows.Markup.ContentPropertyAttribute).Assembly,
            typeof (CodeDomProvider).Assembly,
            typeof(Animatable).Assembly
        }.ToList();

        static void Main(string[] args)
        {
            var pbase = new AssemblyGenerator(typeof (GridUnitType).Assembly);
            pbase.AttributeTableFor("Perspex.Base", "https://github.com/grokys/Perspex", typeof(PerspexObject), gen =>
            {
            });
            pbase.Compile("Perspex.Base.Design.dll");
            pbase.AttributeTableFor("Perspex.Controls", "https://github.com/grokys/Perspex", typeof(GridUnitType), gen =>
            {
                //GenerateContentProperties(typeof (Grid), gen);
            });
            pbase.Compile("Perspex.Controls.Design.dll");
            
        }

        static void GenerateContentProperties(Type anchorType, LineGenerator gen)
        {
            foreach (var type in anchorType.Assembly.GetTypes().Where(t=>t.Namespace == anchorType.Namespace && typeof(PerspexObject).IsAssignableFrom(t)))
            {
                gen.Block(g =>
                {
                    g.WriteLine($"var t = typeof({GetFullTypeName(type)});");
                    g.WriteLine("AddTypeAttributes(t, new Attribute[]");
                    g.Block(ag =>
                    {
                        ag.WriteLine("new EditorBrowsableAttribute(EditorBrowsableState.Always),");
                        if (type.GetProperty("Content") != null)
                            ag.WriteLine(@"new ContentPropertyAttribute(""Content""),");
                        if (type.GetProperty("Children") != null)
                            ag.WriteLine(@"new ContentPropertyAttribute(""Children""),");
                    });
                    g.WriteLine(");");

                });
            }

        }


        private class AssemblyGenerator
        {
            private readonly Assembly _target;
            public List<string> Namespaces { get; }
            private List<string> _provideMetadata = new List<string>();
            public List<Assembly> Imports { get; }
            private LineGenerator _g;
            private StringWriter _writer;

            public AssemblyGenerator(Assembly target)
            {
                _target = target;
                _writer = new StringWriter();
                _g = new LineGenerator(_writer, 0);
                Imports = DefaultImports.Concat(new[] {target}).Concat(
                    target.GetReferencedAssemblies().Select(Assembly.Load)).Distinct().ToList();
                Namespaces = new List<string>
                {
                    "Microsoft.Windows.Design.Metadata",
                    "System",
                    "System.ComponentModel",
                    "System.Reflection",
                    "System.Windows.Markup",
                    "System.IO"
                };
            }

            public void AttributeTableFor(string ns, string xmlns, Type anchorType, Action<LineGenerator> cb)
            {
                _provideMetadata.Add(ns+".RegisterMetadata");
                Class(ns, () =>
                {
                    var cl = new Class("RegisterMetadata") {Interfaces = {"IProvideAttributeTable"}};
                    cl.Properties.Add(new Property("AttributeTable", "AttributeTable")
                    {
                        
                        Get = @"try{"+
                               @"Helper.LoadParent();"
                              + "return new AttributeTableBuilder().CreateTable();"+
                              @"}catch(Exception e){Helper.MessageBox(IntPtr.Zero, e.ToString(), ""WAT"", 0); throw;}"
                    });


                    return cl;
                });
                Class(ns, () =>
                {
                    var cl = new Class("AttributeTableBuilder") {Interfaces = {"AttributeTableBuilderBase"}};

                    var wr = new StringWriter();
                    cb(new LineGenerator(wr, 0));
                    var prolog =
                        $@"Assembly assembly = typeof({GetFullTypeName(anchorType)
                            }).Assembly;
                        this.AddAssemblyAttributes(assembly, new Attribute[]
                        {{
                            new XmlnsDefinitionAttribute(""{
                            xmlns}"", ""{anchorType.Namespace}"")
                        }});";
                    cl.Methods.Add(new Method(cl.Name, " ")
                    {
                        Code = prolog + "\n" + wr
                    });

                    return cl;
                });
            }

            private void Class(string ns, Func<Class> cb)
            {
                _g.WriteLine("namespace " + ns);
                _g.Block(g => cb().Generate(g));
            }

            public void Compile(string targetDll)
            {
                targetDll = Path.GetFullPath(targetDll);
                Directory.CreateDirectory(Path.GetDirectoryName(targetDll));
                if (File.Exists(targetDll))
                    File.Delete(targetDll);
                var source = Path.Combine(Path.GetTempPath(), $"PerspexDesigner_{Guid.NewGuid()}.cs");
                var sourceCode = String.Join("\n", Namespaces.Select(i => $"using {i};")) + "\n";
                sourceCode += "\n\n" +
                              string.Join("\n",
                                  _provideMetadata.Select(n => $"[assembly: ProvideMetadata(typeof({n}))]"));
                sourceCode += _writer;


                using (
                    var tr =
                        new StreamReader(
                            typeof (Program).Assembly.GetManifestResourceStream(
                                "Perspex.Markup.Xaml.Metadata.Common.AttributeTableBuilderBase.cs")))
                    sourceCode = sourceCode + "\n\n" + tr.ReadToEnd();

                sourceCode = sourceCode.Replace("\r\n", "\n").Replace("\n", "\r\n");
                File.WriteAllText(source, sourceCode);
                var compiler = CodeDomProvider.CreateProvider("CSharp");
                var compiled = compiler.CompileAssemblyFromFile(
                    new CompilerParameters(Imports.Select(a => a.GetModules()[0].FullyQualifiedName).ToArray()
                        , targetDll), source);
                if (compiled.Errors.Count > 0)
                {
                    foreach (CompilerError ce in compiled.Errors)
                    {
                        Console.Error.WriteLine("  {0}", ce.ToString());
                        Console.Error.WriteLine();
                    }
                    
                }
                File.Delete(source);
                if (compiled.Errors.Count != 0)
                    Environment.Exit(1);
            }
        }


        /*
        static void Main(string[] args)
        {
            var writer = new StringWriter();
            var g = new LineGenerator(writer, 0);
            g.WriteLine("namespace Perspex.DesignerSupport").Block(ns =>
            {
                foreach (
                    var type in typeof(ITopLevelImpl).Assembly.GetTypes().Where(t => typeof(PerspexObject).IsAssignableFrom(t))
                    )
                {
                    if (!type.IsAbstract)
                        GenerateControl(type).Generate(ns);
                }
            });
            File.WriteAllText(@"..\..\..\Perspex.DesignerSupport\Controls.generated.cs", writer.ToString());
        }*/

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
        /*
        private static Class GenerateControl(Type type)
        {
            var cl = new Class(type.Name);

            cl.Interfaces.Add("IWpfWrapper");
            cl.Properties.Add(new Property("PerspexObject", "object")
            {
                Get = "return _base;"
            });
            cl.Fields.Add(new Field("_base", GetFullTypeName(type)) { Initializer = $"new {type.FullName}()" });

            if (type != typeof(Window))
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
                if (prop.PropertyType == typeof(ITopLevelImpl))
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

        }*/
    }
}


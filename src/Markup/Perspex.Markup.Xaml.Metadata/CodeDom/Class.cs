using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Perspex.Markup.Xaml.Metadata.CodeDom
{
    interface IGeneratable
    {
        void Generate(LineGenerator generator);
    }

    public class ClassAttribute : IGeneratable
    {
        private readonly string[] _arguments;
        public string Type { get; set; }

        public ClassAttribute(string type, params string[] arguments)
        {
            _arguments = arguments;
            Type = type;
        }

        public void Generate(LineGenerator generator)
        {
            generator.WriteLine($"[{Type}( {string.Join(",", _arguments)}) ]");
        }
    }

    public class Class : IGeneratable
    {
        
        public string Name { get; set; }
        public List<ClassAttribute> Attributes { get; set; } = new List<ClassAttribute>();
        public List<string> Interfaces { get; set; } = new List<string>();
        public List<Method> Methods { get; set; } = new List<Method>();
        public List<Property> Properties { get; set; } = new List<Property>();
        public List<Field> Fields { get; set; } = new List<Field>();
        public Class(string name)
        {
            Name = name;
        }
        
        public void Generate(LineGenerator generator)
        {
            foreach (var attr in Attributes)
                attr.Generate(generator);
            generator[
                $"partial class {Name} {(Interfaces?.Count > 0 ? ":  " + string.Join(", ", Interfaces) : "")}"]
                .Block(b =>
                {
                    foreach (var g in ((IEnumerable<IGeneratable>) Fields).Concat(Properties).Concat(Methods))
                        g.Generate(b);
                });
        }
    }

    public class CodeEntity
    {
        public string Code { get; set; }

        public static void GenerateCodeBlockFor(LineGenerator generator, string code)
        {
            generator.Block(n =>
            {
                foreach (var l in code.Split('\n').Select(c => c.Trim('\r')))
                    n.WriteLine(l);
            });
        }

        public void GenerateCodeBlock(LineGenerator generator) => GenerateCodeBlockFor(generator, Code);
    }

    public class Method : CodeEntity, IGeneratable
    {
        public Method(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }

        public List<Argument> Arguments { get; set; } = new List<Argument>();
        

        public void Generate(LineGenerator generator)
        {
            GenerateCodeBlock(generator[
                    $"public {Type ?? "void"} {Name} ({string.Join(",", Arguments.Select(a => $"{a.Type} {a.Name}"))})"]);
        }
    }



    public class Field : IGeneratable
    {
        public Field(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }
        public bool IsAutoProperty { get; set; }

        public bool IsStatic { get; set; }
        public string Initializer { get; set; }

        public void Generate(LineGenerator generator) => generator.WriteLine(
            $"public{(IsStatic ? " static" : " ")} {Type} {Name} {(IsAutoProperty ? "{get;set;}" : "")} {(Initializer != null ? " = " + Initializer : "")};");
    }

    public class Property : IGeneratable
    {
        public bool IsStatic { get; set; }
        public Property(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }
        public string Get { get; set; }
        public string Set { get; set; }
        public void Generate(LineGenerator generator)
        {
            generator[$"public{(IsStatic ? " static" : " ")} {Type} {Name}"].Block(p =>
            {
                if (Get != null)
                    CodeEntity.GenerateCodeBlockFor(p["get"], Get);
                if (Set != null)
                    CodeEntity.GenerateCodeBlockFor(p["set"], Set);
            });
        }
    }
    
    public class Argument
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }


    public class LineGenerator
    {
        private readonly TextWriter _writer;
        private int _offset;

        public LineGenerator(TextWriter writer, int offset)
        {
            _writer = writer;
            _offset = offset;
        }

        public LineGenerator Nested => new LineGenerator(_writer, _offset + 1);

        public LineGenerator WriteLine(string line)
        {
            _writer.Write(new string('\t', _offset));
            _writer.WriteLine(line);
            return this;
        }

        public LineGenerator Offset(Action<LineGenerator> nested)
        {
            nested(Nested);
            return this;
        }

        public LineGenerator Offset(string closeWith, Action<LineGenerator> nested)
        {
            nested(Nested);
            WriteLine(closeWith);
            return this;
        }
        public LineGenerator Block(Action<LineGenerator> nested)
        {
            WriteLine("{");
            nested(Nested);
            WriteLine("}");
            return this;
        }

        public LineGenerator this[string s]
        {
            get
            {
                WriteLine(s);
                return this;
            }
        }
    }
}

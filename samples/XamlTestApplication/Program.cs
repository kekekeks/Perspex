using System.Threading.Tasks;
using Perspex.Input;

namespace XamlTestApplication
{
    using System;
    using System.Diagnostics;
    using System.Windows.Threading;
    using Perspex;
    using Perspex.Collections;
    using Perspex.Controls;
    using Perspex.Controls.Templates;
    using ReactiveUI;
    using Views;

    class Item
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    class Node
    {
        public Node()
        {
            this.Children = new PerspexList<Node>();
        }

        public string Name { get; set; }
        public PerspexList<Node> Children { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var foo = Dispatcher.CurrentDispatcher;

            App application = new App
            {
                DataTemplates = new DataTemplates
                {
                    new TreeDataTemplate<Node>(
                        x => new TextBlock { Text = x.Name },
                        x => x.Children,
                        x => true),
                },
            };

            var testCommand = ReactiveCommand.Create();
            testCommand.Subscribe(_ => Debug.WriteLine("Test command executed."));
            
            Spawner();
            
            Application.Current.Run(new Never());
        }

        static async void Spawner()
        {
            while (true)
            {
                var window = new MainWindow();
                window.Show();
                await Task.Delay(10);
                window.Close();
                await Task.Delay(10);
            }
        }

        class Never : ICloseable
        {
            public event EventHandler Closed;
        }      
    }
}

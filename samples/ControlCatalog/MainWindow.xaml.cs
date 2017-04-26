using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Rendering;

namespace ControlCatalog
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.AttachDevTools();
            Renderer.DrawDirtyRects = true;
            var content = (Control) Content;
            content.FindControl<CheckBox>("RenderDirty")
                .GetObservable(CheckBox.IsCheckedProperty).Subscribe(v => Renderer.DrawDirtyRects = v);
            content.FindControl<CheckBox>("RenderLayers")
                .GetObservable(CheckBox.IsCheckedProperty).Subscribe(v =>
                {
                    var deferred = Renderer as DeferredRenderer;
                    deferred.DrawLayers = v;
                });
        }

        private void InitializeComponent()
        {
            // TODO: iOS does not support dynamically loading assemblies
            // so we must refer to this resource DLL statically. For
            // now I am doing that here. But we need a better solution!!
            var theme = new Avalonia.Themes.Default.DefaultTheme();
            theme.FindResource("Button");
            AvaloniaXamlLoader.Load(this);
        }
    }
}

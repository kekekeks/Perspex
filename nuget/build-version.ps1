$ErrorActionPreference = "Stop"

rm -Force -Recurse .\Perspex -ErrorAction SilentlyContinue
rm -Force -Recurse .\Perspex.Desktop -ErrorAction SilentlyContinue
rm -Force -Recurse .\Perspex.Skia.Desktop -ErrorAction SilentlyContinue

rm -Force -Recurse *.nupkg -ErrorAction SilentlyContinue
Copy-Item template Perspex -Recurse
sv lib "Perspex\lib\portable-windows8+net45"
sv build "Perspex.Desktop\lib\net45"

sv skia_root "Perspex.Skia.Desktop"
sv skia_lib "Perspex.Skia.Desktop\lib\net45"
sv skia_native "Perspex.Skia.Desktop\build\net45\native"

mkdir $lib -ErrorAction SilentlyContinue
mkdir $build -ErrorAction SilentlyContinue
mkdir $skia_lib


Copy-Item ..\src\Perspex.Animation\bin\Release\Perspex.Animation.dll $lib
Copy-Item ..\src\Perspex.Animation\bin\Release\Perspex.Animation.xml $lib
Copy-Item ..\src\Perspex.Application\bin\Release\Perspex.Application.dll $lib
Copy-Item ..\src\Perspex.Application\bin\Release\Perspex.Application.xml $lib
Copy-Item ..\src\Perspex.Base\bin\Release\Perspex.Base.dll $lib
Copy-Item ..\src\Perspex.Base\bin\Release\Perspex.Base.xml $lib
Copy-Item ..\src\Perspex.Controls\bin\Release\Perspex.Controls.dll $lib
Copy-Item ..\src\Perspex.Controls\bin\Release\Perspex.Controls.xml $lib
Copy-Item ..\src\Perspex.Diagnostics\bin\Release\\Perspex.Diagnostics.dll $lib
Copy-Item ..\src\Perspex.Diagnostics\bin\Release\\Perspex.Diagnostics.xml $lib
Copy-Item ..\src\Perspex.Input\bin\Release\Perspex.Input.dll $lib
Copy-Item ..\src\Perspex.Input\bin\Release\Perspex.Input.xml $lib
Copy-Item ..\src\Perspex.Interactivity\bin\Release\Perspex.Interactivity.dll $lib
Copy-Item ..\src\Perspex.Interactivity\bin\Release\Perspex.Interactivity.xml $lib
Copy-Item ..\src\Perspex.Layout\bin\Release\Perspex.Layout.dll $lib
Copy-Item ..\src\Perspex.Layout\bin\Release\Perspex.Layout.xml $lib
Copy-Item ..\src\Perspex.SceneGraph\bin\Release\Perspex.SceneGraph.dll $lib
Copy-Item ..\src\Perspex.SceneGraph\bin\Release\Perspex.SceneGraph.xml $lib
Copy-Item ..\src\Perspex.Styling\bin\Release\Perspex.Styling.dll $lib
Copy-Item ..\src\Perspex.Styling\bin\Release\Perspex.Styling.xml $lib
Copy-Item ..\src\Perspex.Themes.Default\bin\Release\Perspex.Themes.Default.dll $lib
Copy-Item ..\src\Perspex.Themes.Default\bin\Release\Perspex.Themes.Default.xml $lib
Copy-Item ..\src\Markup\Perspex.Markup\bin\Release\Perspex.Markup.dll $lib
Copy-Item ..\src\Markup\Perspex.Markup\bin\Release\Perspex.Markup.xml $lib
Copy-Item ..\src\Markup\Perspex.Markup.Xaml\bin\Release\Perspex.Markup.Xaml.dll $lib
Copy-Item ..\src\Markup\Perspex.Markup.Xaml\bin\Release\Perspex.Markup.Xaml.xml $lib
Copy-Item ..\src\Perspex.HtmlRenderer\bin\Release\Perspex.HtmlRenderer.dll $lib
Copy-Item ..\src\Perspex.ReactiveUI\bin\Release\Perspex.ReactiveUI.dll $lib

Copy-Item ..\src\Windows\Perspex.Direct2D1\bin\Release\Perspex.Direct2D1.dll $build
Copy-Item ..\src\Windows\Perspex.Win32\bin\Release\Perspex.Win32.dll $build
Copy-Item ..\src\Gtk\Perspex.Gtk\bin\Release\Perspex.Gtk.dll $build
Copy-Item ..\src\Gtk\Perspex.Cairo\bin\Release\Perspex.Cairo.dll $build

Copy-Item skia\build $skia_root -recurse
mkdir $skia_native
Copy-Item ..\src\Skia\native\Windows $skia_native -recurse
Copy-Item ..\src\Skia\native\Linux $skia_native -recurse
Copy-Item ..\src\Skia\Perspex.Skia.Desktop\bin\Release\Perspex.Skia.Desktop.dll $skia_lib


(gc Perspex\Perspex.nuspec).replace('#VERSION#', $args[0]) | sc Perspex\Perspex.nuspec
(gc Perspex\Perspex.Desktop.nuspec).replace('#VERSION#', $args[0]) | sc Perspex.Desktop\Perspex.Desktop.nuspec
(gc Perspex\Perspex.Skia.Desktop.nuspec).replace('#VERSION#', $args[0]) | sc Perspex.Skia.Desktop\Perspex.Skia.Desktop.nuspec

nuget.exe pack Perspex\Perspex.nuspec
nuget.exe pack Perspex.Desktop\Perspex.Desktop.nuspec
nuget.exe pack Perspex.Skia.Desktop\Perspex.Skia.Desktop.nuspec
rm -Force -Recurse .\Perspex
rm -Force -Recurse .\Perspex.Desktop
rm -Force -Recurse .\Perspex.Skia.Desktop
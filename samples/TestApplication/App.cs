// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using Perspex;
using Perspex.Cairo;
using Perspex.Direct2D1;
using Perspex.Gtk;
using Perspex.Skia;
using Perspex.Themes.Default;
using Perspex.Win32;

namespace TestApplication
{
    public class App : Application
    {
        public App()
        {
            RegisterServices();
            GtkPlatform.Initialize();
            SkiaPlatform.Initialize();
            Styles = new DefaultTheme();
            Styles.Add(new SampleTabStyle());
        }
    }
}

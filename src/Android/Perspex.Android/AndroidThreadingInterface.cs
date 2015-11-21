using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Perspex.Platform;
using Perspex.Shared.PlatformSupport;

namespace Perspex.Android
{
    class AndroidThreadingInterface : MobileThreadingInterface
    {
        private Handler _handler;
        public AndroidThreadingInterface()
        {
            _handler = new Handler(global::Android.App.Application.Context.MainLooper);
        }
        
        protected override void PostOnMainThread(Action action) => _handler.Post(action);

        public override bool CurrentThreadIsLoopThread => Looper.MainLooper.Thread.Equals(Java.Lang.Thread.CurrentThread());
    }
}
 
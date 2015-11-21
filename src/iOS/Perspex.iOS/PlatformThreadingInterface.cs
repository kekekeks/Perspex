using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Foundation;
using Perspex.Platform;
using Perspex.Shared.PlatformSupport;

namespace Perspex.iOS
{
    class PlatformThreadingInterface : MobileThreadingInterface
    {
        readonly NSObject _nobj = new NSObject();
        protected override void PostOnMainThread(Action action)
        {
            _nobj.BeginInvokeOnMainThread(action);
        }
        public override bool CurrentThreadIsLoopThread => NSThread.Current.IsMainThread;
    }
}

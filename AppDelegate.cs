using System;
using System.Collections.Generic;
using System.Linq;
using iOS.Data;
using MonoTouch.Dialog;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;
       

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            window = new UIWindow(UIScreen.MainScreen.Bounds);

            //viewController = new MyViewController();
            //window.RootViewController = viewController;

            var root = new RootElement("Influencers");

            var dvc = new InfluencersController(UITableViewStyle.Plain, new RootElement("Influencers"));
            var nav = new UINavigationController(dvc);

            window.RootViewController = nav;

            window.MakeKeyAndVisible();

            return true;
        }
    }
}


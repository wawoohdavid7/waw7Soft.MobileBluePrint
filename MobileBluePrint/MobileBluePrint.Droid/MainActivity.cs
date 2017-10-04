using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MobileBluePrint.Shared;
using MobileBluePrint.Core.Objects;

namespace MobileBluePrint.Droid
{
    [Activity(
        Label = "MobileBluePrint", 
        Icon = "@drawable/icon", 
        Theme = "@style/MainTheme", 
		ScreenOrientation = ScreenOrientation.Portrait,
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(AutofacContainer.GetApplicationInstance(new AndroidContainerBuilder(),new AppModuleService()));
        }
    }
}


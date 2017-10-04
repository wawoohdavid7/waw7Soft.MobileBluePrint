using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MobileBluePrint.Droid.CustomRenderer;
using MobileBluePrint.CustomControls;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(CustomMasterDetail), typeof(CustomMasterDetailRenderer))]
namespace MobileBluePrint.Droid.CustomRenderer
{
    public class CustomMasterDetailRenderer : MasterDetailPageRenderer
    {
        public CustomMasterDetailRenderer()
        {
            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Lollipop)
            {
                //Take into consideration the status bar for API level 19 and above.
                SetFitsSystemWindows(true);
            }
        }
    }
}
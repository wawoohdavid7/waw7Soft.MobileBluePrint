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

namespace MobileBluePrint.Droid
{
    public class Android_VersionNumber : IVersionNumber
    {
        public string GetVersionNumber()
        {
            return "1.0";
        }
    }
}
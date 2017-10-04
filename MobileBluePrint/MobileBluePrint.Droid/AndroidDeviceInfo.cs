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
using MobileBluePrint.Core.Interfaces;

namespace MobileBluePrint.Droid
{
    public class AndroidDeviceInfo : IDeviceInfo, IAndroidDeviceInfo
    {
        public string OSVersion
        {
            get
            {
                return Build.VERSION.Release;
            }
        }

        public string Manufacturer
        {
            get
            {
                return Build.Manufacturer;
            }
        }

        public string Model
        {
            get
            {
                return Build.Model;
            }
        }

        public bool IsKitkatAboveVersion
        {
            get
            {
                return Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Lollipop;
            }
        }
    }
}
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
using Autofac;
using MobileBluePrint.Core.Interfaces;

namespace MobileBluePrint.Droid
{
    public class AndroidContainerBuilder : IPlatformContainerBuilder
    {
        public ContainerBuilder RegisterPlatformServiceComponents()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Android_VersionNumber>().As<IVersionNumber>().SingleInstance();
            builder.RegisterType<AndroidDeviceInfo>().As<IDeviceInfo>().SingleInstance();

            return builder;
        }
    }
}
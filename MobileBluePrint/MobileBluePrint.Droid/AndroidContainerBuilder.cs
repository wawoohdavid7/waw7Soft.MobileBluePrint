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
namespace MobileBluePrint.Droid
{
    class AndroidContainerBuilder : IPlatformContainerBuilder
    {
        public ContainerBuilder RegisterPlatformComponents()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Android_VersionNumber>().As<IVersionNumber>().SingleInstance();

            return builder;
        }
    }
}
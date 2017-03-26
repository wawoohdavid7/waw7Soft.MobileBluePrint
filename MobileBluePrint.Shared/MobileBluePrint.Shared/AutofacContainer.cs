using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileBluePrint.Shared
{
    public static class AutofacContainer
    {
        public static IContainer AppContainer { get; private set; }

        public static Xamarin.Forms.Application GetApplicationInstance(IPlatformContainerBuilder platformContainer)
        {
            var containerBuilder = platformContainer.RegisterPlatformComponents();

            containerBuilder.RegisterModule(new AppModule());
            AppContainer = containerBuilder.Build();

            return AppContainer.Resolve<Xamarin.Forms.Application>();
        }
    }
}

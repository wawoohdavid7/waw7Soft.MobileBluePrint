using Autofac;
using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileBluePrint.Core.Objects
{
    public static class AutofacContainer
    {
        public static Xamarin.Forms.Application GetApplicationInstance(IPlatformContainerBuilder platformContainer, IAppModuleService appModuleService)
        {
            var containerBuilder = platformContainer.RegisterPlatformServiceComponents();

            containerBuilder.RegisterModule(new BaseModule());
            appModuleService.RegisterModule(containerBuilder);
            var container = containerBuilder.Build();

            var tmp =  container.Resolve<Xamarin.Forms.Application>();

            return tmp;
        }

    }
}

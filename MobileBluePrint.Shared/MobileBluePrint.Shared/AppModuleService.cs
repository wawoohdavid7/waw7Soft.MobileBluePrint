using MobileBluePrint.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace MobileBluePrint.Shared
{
    public class AppModuleService : IAppModuleService
    {
        public void RegisterModule(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new AppModule());
        }
    }
}

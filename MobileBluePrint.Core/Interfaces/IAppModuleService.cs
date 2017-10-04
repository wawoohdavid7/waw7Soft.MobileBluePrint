using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBluePrint.Core.Interfaces
{
    public interface IAppModuleService
    {
        void RegisterModule(ContainerBuilder containerBuilder);
    }
}

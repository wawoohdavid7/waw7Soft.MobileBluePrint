﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace MobileBluePrint.Core.Interfaces
{
    public interface IPlatformContainerBuilder
    {
        ContainerBuilder RegisterPlatformServiceComponents();
    }
}

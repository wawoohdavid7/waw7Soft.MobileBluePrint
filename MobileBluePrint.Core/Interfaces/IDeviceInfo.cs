using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBluePrint.Core.Interfaces
{
    public interface IDeviceInfo
    {
        string Model { get; }
        string Manufacturer { get; }
        string OSVersion { get; }
    }
}

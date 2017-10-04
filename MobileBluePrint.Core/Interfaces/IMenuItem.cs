using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBluePrint.Core.Interfaces
{
    public interface IMenuItem
    {
        string GetTitle();

        string GetPageKey();

        bool IsDefault { get; }
    }


}

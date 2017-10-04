using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobileBluePrint.Core.Interfaces
{
    public interface IMasterPageMenuItem
    {
        string ItemText { get; }
        string PageKey { get; }
        bool IsDefault { get; }
    }
}

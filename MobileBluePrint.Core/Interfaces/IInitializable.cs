using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBluePrint.Core.Interfaces
{
    public interface IInitializable
    {
        Task Initialize<TParam>(TParam param);
    }
}

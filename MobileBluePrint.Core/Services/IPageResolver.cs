using MobileBluePrint.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBluePrint.Core.Services
{
    public interface IPageResolver
    {
        Page ResolvePage(Object key, params object[] paramList);
        BaseViewModel ResolveViewModel(object key);
    }
}

using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBluePrint.Core.Services
{
    public interface IMasterPageService
    {
        List<IMasterPageMenuItem> GetMenuItemList();
        void InitializeMasterDetailPage(MasterDetailPage mainPage);
        void SetRootPage(string rootPageKey);
    }
}

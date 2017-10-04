using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBluePrint.Core.Services
{
    public interface INavigationService
    {
        //Task PushPageAsync(object pageKey);
        Task PushPageAsync<TParam>(object pageKey, TParam param);

        Task PopToRootPageAsync(object rootPageKey = null);

        Task NavigateToDropdownPageAsync<TParam>(TParam param, object pageKey);

        Task SetRootPage(string rootPage);

        void Initialize();

        void SetNavigation(NavigationPage navigationPage);
    }
}

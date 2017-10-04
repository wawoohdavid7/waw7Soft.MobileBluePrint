using MobileBluePrint.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MobileBluePrint.Core.Services;
using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Objects;
using MobileBluePrint.Core.Objects;
using MobileBluePrint.ViewModels;
using MobileBluePrint.Views;

namespace MobileBluePrint.Services
{
    public class MasterPageService : IMasterPageService
    {
        private readonly IPageResolver _pageResolver;
        private readonly INavigationService _navigationService;
        private readonly IDeviceInfo _deviceInfo;

        public MasterPageService(IPageResolver pageResolver, INavigationService navigationService, IDeviceInfo deviceInfo)
        {
            _navigationService = navigationService;
            _pageResolver = pageResolver;
            _deviceInfo = deviceInfo;
        }

        public List<IMasterPageMenuItem> GetMenuItemList()
        {

            var menuItemList = new List<IMasterPageMenuItem>
            {
                //TODO: remove constructor parameter, use action instead.
                new Page1MenuItem(this),
                new Page2MenuItem(this),

            };

            return menuItemList;
        }

        
        public void InitializeMasterDetailPage(MasterDetailPage mainPage)
        {

            var masterpage = _pageResolver.ResolvePage(ViewNames.Master);

            //HACK: Adjusts to truncated master page, maybe fixed in future xamarin versions.
            if (Device.OS == TargetPlatform.Android && ((IAndroidDeviceInfo)_deviceInfo).IsKitkatAboveVersion)
            {
                masterpage.Padding = new Thickness(0, 25, 0, 0);
            }

            mainPage.Master = masterpage;
            MainPage = mainPage;

            var defaultRootPage = GetDefaultRootPage();

            SetRootPage(defaultRootPage);
        }


        public static MasterDetailPage MainPage { get; set; }

        public void SetRootPage(string rootPageKey)
        {
            var menuItem = GetMenuItemList().FirstOrDefault(m => m.PageKey == rootPageKey);

            var rootPage = _pageResolver.ResolvePage(menuItem.PageKey);

            SetRootPage(rootPage);
        }

        private void SetRootPage(Page rootPage)
        {
            var navigationPage = new NavigationPage(rootPage);
            MainPage.Detail = navigationPage;
            MainPage.IsPresented = false;

            _navigationService.SetNavigation(navigationPage);
        }

        private Page GetDefaultRootPage()
        {
            var defaultMenu = GetMenuItemList().FirstOrDefault(f => f.IsDefault);
            var page = _pageResolver.ResolvePage(defaultMenu.PageKey);

            return page;
        }
    }
}

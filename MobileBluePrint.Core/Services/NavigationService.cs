using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBluePrint.Core.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IPageResolver _pageResolver;
        public NavigationService(IPageResolver pageResolver)
        {
            _pageResolver = pageResolver;
        }

        public void Initialize()
        {
        }

        public void InitializeMasterPage()
        {

        }

        public Task SetRootPage(string rootPageKey)
        {
            //var defaultMenu = GetMenuItemList().FirstOrDefault(f => f.IsDefault);
            //var page = _pageResolver.ResolvePage(defaultMenu.PageKey);
            //var vm = _pageResolver.ResolveViewModel(defaultMenu.PageKey);
            //if (vm != null)
            //{
            //    page.BindingContext = vm;
            //}



            //var navigationPage = new NavigationPage(page);

            //_navigationService.Navigation = navigationPage.Navigation;
            //return navigationPage;

            var page = _pageResolver.ResolvePage(rootPageKey);
            var vm = _pageResolver.ResolveViewModel(rootPageKey);
            //if (vm != null)
            //{
            //    page.BindingContext = vm;
            //}


            return Navigation.PushAsync(page);
        }

        public void SetNavigation(NavigationPage navigationPage)
        {
            Navigation = navigationPage.Navigation;
        }


        private INavigation Navigation { get; set; }

        //public Task PushPageAsync<TParam>(object pageKey, TParam param)
        //{
        //    var vm = _pageResolver.ResolveViewModel(pageKey);
        //    return InitializeViewModel(param, vm);
        //}

        public Task PushPageAsync<TParam>(object pageKey, TParam param)
        {
            var page = _pageResolver.ResolvePage(pageKey);

            //var vm = _pageResolver.ResolveViewModel(pageKey);

            //if (vm != null)
            //{
            //    InitializeViewModel(param, vm);
            //    page.BindingContext = vm;
            //}

            return Navigation.PushAsync(page);
        }

        //private Task InitializeViewModel<TParam>(TParam param, BaseViewModel vm)
        //{
        //    var initializable = (IInitializable)vm;

        //    return initializable?.Initialize(param);
        //}

        //public Task PushPageAsync(object pageKey, object[] param = null)
        //{
        //    if (param != null)
        //    {
        //        Navigation.push
        //    }
        //}

        public async Task PopToRootPageAsync(object rootPageKey = null)
        {
            await Navigation.PopToRootAsync();

            //if (rootPageKey != null)
            //{
            //    await SetRootPage((string)rootPageKey);
            //}


        }

        public async Task NavigateToDropdownPageAsync<TParam>(TParam param, object pageKey)
        {
            await PushPageAsync(pageKey, param);
        }
    }
}

using Autofac;
using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.ViewModels;
using Xamarin.Forms;

namespace MobileBluePrint.Core.Services
{
    //TODO: create initializable machanism.
    public class PageResolver : IPageResolver
    {
        private readonly ILifetimeScope _lifetimeScope;
        private readonly IMasterPageService _masterPageService;

        public PageResolver(ILifetimeScope lifetimeScope)
        {
            //_masterPageService = masterPageService;
            _lifetimeScope = lifetimeScope;
        }

        public BaseViewModel ResolveViewModel(object key)
        {
            object vm;
            bool hasViewModel = _lifetimeScope.TryResolveKeyed(key, typeof(BaseViewModel), out vm);

            return hasViewModel ? (BaseViewModel)vm : null;
        }

        private void InitializeIfNeeded(BaseViewModel vm,params object[] paramList)
        {
            if (vm is IInitializable && paramList != null)
            {
                ((IInitializable)vm).Initialize(paramList);
            }


            //var initializable = (IInitializable)vm;
            //initializable?.Initialize(paramList);

        }

        public Page ResolvePage(object key, params object[] paramList)
        {
            var page = _lifetimeScope.ResolveKeyed<Page>(key);

            //object vm;
            //bool hasViewModel = _lifetimeScope.TryResolveKeyed(key, typeof(BaseViewModel), out vm);

            BaseViewModel vm = ResolveViewModel(key);
            if (vm != null)
            {
                InitializeIfNeeded(vm, paramList);
                page.BindingContext = vm;
            }



            //if (page is MasterDetailPage)
            //{
            //    ((MasterDetailPage)page).Master = _lifetimeScope.ResolveKeyed<Page>(_masterPageService.GetMasterPageKey());
            //}


            return page;
        }

    }
}

using Autofac;
using MobileBluePrint.Core.Constants;
using MobileBluePrint.Core.Pages;
using MobileBluePrint.Core.Services;
using MobileBluePrint.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBluePrint.Core.Objects
{
    public class BaseModule : Module
    {
        private ContainerBuilder _builder = null;
        protected override void Load(ContainerBuilder builder)
        {
            _builder = builder;

            RegisterServices();
            RegisterViews();
            RegisterViewModels();
        }

        private void RegisterServices()
        {
            _builder.RegisterType<PageResolver>().As<IPageResolver>().SingleInstance();
            _builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
        }

        private void RegisterViews()
        {
            _builder.RegisterType<DropdownPage>().Named<Page>(CoreViewNames.Dropdown).SingleInstance();
        }

        private void RegisterViewModels()
        {
            _builder.RegisterType<DropdownPageViewModel>().Named<BaseViewModel>(CoreViewNames.Dropdown).SingleInstance();
        }

    }
}

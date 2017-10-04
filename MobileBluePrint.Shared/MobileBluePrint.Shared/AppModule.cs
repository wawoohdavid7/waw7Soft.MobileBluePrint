using Autofac;
using MobileBluePrint.Constants;
using MobileBluePrint.Core.Services;
using MobileBluePrint.Core.ViewModels;
using MobileBluePrint.Services;
using MobileBluePrint.ViewModels;
using MobileBluePrint.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileBluePrint.Shared
{
    public class AppModule : Module
    {
        private ContainerBuilder _builder = null;
        protected override void Load(ContainerBuilder builder)
        {
            _builder = builder;

            _builder.RegisterType<App>().As<Xamarin.Forms.Application>().SingleInstance();

            RegisterViews();
            RegisterViewModels();
            RegisterServices();
        }

        private void RegisterViewModels()
        {
            //_builder.RegisterType<MainPageViewModel>().As<IMainPageViewModel>().SingleInstance();
           _builder.RegisterType<MainPageViewModel>().Named<BaseViewModel>(ViewNames.Main).WithProperty("Test", "testvalue").SingleInstance();
           _builder.RegisterType<Page2ViewModel>().Named<BaseViewModel>(ViewNames.Page2).WithProperty("Test", "testvalue").SingleInstance();
           _builder.RegisterType<Page1ViewModel>().Named<BaseViewModel>(ViewNames.Page1).SingleInstance();
           _builder.RegisterType<Page2Sub1ViewModel>().Named<BaseViewModel>(ViewNames.Page2Sub1).SingleInstance();
           _builder.RegisterType<MasterPageViewModel>().Named<BaseViewModel>(ViewNames.Master).SingleInstance();
            
            //_builder.RegisterType<MainPageViewModel>().As<IMainPageViewModel>().WithProperty("Test", "testvalue").SingleInstance();
        }

        private void RegisterViews()
        {
            _builder.RegisterType<MainPage>().Named<Page>(ViewNames.Main).SingleInstance();
            _builder.RegisterType<MasterPage>().Named<Page>(ViewNames.Master).SingleInstance();
            _builder.RegisterType<Page1>().Named<Page>(ViewNames.Page1).SingleInstance();
            _builder.RegisterType<Page2>().Named<Page>(ViewNames.Page2).SingleInstance();
            _builder.RegisterType<Page2Sub1>().Named<Page>(ViewNames.Page2Sub1).SingleInstance();
            _builder.RegisterType<ProfilePage>().Named<Page>(ViewNames.Profile).SingleInstance();

        }

        private void RegisterServices()
        {
            _builder.RegisterType<MasterPageService>().As<IMasterPageService>().SingleInstance();



        }
    }
}

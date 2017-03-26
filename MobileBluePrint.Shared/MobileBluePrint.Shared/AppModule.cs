using Autofac;
using MobileBluePrint.Constants;
using MobileBluePrint.ViewModels;
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
        }

        private void RegisterViewModels()
        {
            _builder.RegisterType<MainPageViewModel>().As<IMainPageViewModel>().SingleInstance();
        }

        private void RegisterViews()
        {
            _builder.RegisterType<MainPage>().Named<Page>(ViewNames.Main).SingleInstance();

        }
    }
}

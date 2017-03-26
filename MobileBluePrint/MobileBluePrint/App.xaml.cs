using Autofac;
using MobileBluePrint.Constants;
using MobileBluePrint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobileBluePrint
{
    public partial class App : Application
    {
        public App(IVersionNumber versionNumber, ILifetimeScope appContainer, IMainPageViewModel vm)
        {
            InitializeComponent();

            string tmp = versionNumber.GetVersionNumber();

            var view = appContainer.ResolveNamed<Page>(ViewNames.Main);
            view.BindingContext = vm;
            MainPage = view;
            //MainPage.BindingContext = mainVM;

            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using Autofac;
using MobileBluePrint.Constants;
using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.Services;
using MobileBluePrint.Objects;
using MobileBluePrint.ViewModels;
using MobileBluePrint.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobileBluePrint
{
    public partial class App : Application
    {
        public App(IPageResolver pageResolver, IMasterPageService masterPageService)
        {
            InitializeComponent();


            var mainpage = pageResolver.ResolvePage(ViewNames.Main);
            masterPageService.InitializeMasterDetailPage((MasterDetailPage)mainpage);


            MainPage = mainpage;

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

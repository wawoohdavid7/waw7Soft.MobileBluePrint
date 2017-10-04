using MobileBluePrint.Constants;
using MobileBluePrint.Core.Objects;
using MobileBluePrint.Core.Services;
using MobileBluePrint.Core.ViewModels;
using MobileBluePrint.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileBluePrint.ViewModels
{
    public class Page2ViewModel : BaseViewModel
    {
        private INavigationService _navigationService;
        public Page2ViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            _navigationService = navigationService;
            //GoProfilePageCommand = new Command(async () => 
            //{

            //});

            TestCommand = new Command(async () => 
            {
                await _navigationService.PushPageAsync(ViewNames.Page2Sub1,0);
            });
        }

        public string Test { get; set; }
        public ICommand GoProfilePageCommand { get; set; }
        public ICommand TestCommand { get; private set; }

    }
}

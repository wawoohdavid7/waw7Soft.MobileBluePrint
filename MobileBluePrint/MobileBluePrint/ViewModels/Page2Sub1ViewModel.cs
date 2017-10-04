using MobileBluePrint.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileBluePrint.Core.Services;
using System.Windows.Input;
using Xamarin.Forms;
using MobileBluePrint.Constants;

namespace MobileBluePrint.ViewModels
{
    public class Page2Sub1ViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IMasterPageService _masterPageService;
        public Page2Sub1ViewModel(INavigationService navigationService, IMasterPageService masterPageService) : base(navigationService)
        {
            _navigationService = navigationService;
            _masterPageService = masterPageService;

            Command1 = new Command(async () => 
            {
                //TODO: try moving this logic to masterpageservice.
                //if navigation is the current, then pop the old first.
                await _navigationService.PopToRootPageAsync();

                 _masterPageService.SetRootPage(ViewNames.Page1);
            });
        }

        public ICommand Command1 { get; set; }
    }
}

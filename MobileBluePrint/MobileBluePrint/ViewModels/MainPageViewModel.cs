using MobileBluePrint.Core.Services;
using MobileBluePrint.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBluePrint.ViewModels
{
    public class MainPageViewModel : BaseViewModel, IMainPageViewModel
    {
        public MainPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
        }
        public string TestProp
        {
            get
            {
                return "Test";
            }
        }

        public string Test { get; set; }
    }
}

using MobileBluePrint.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileBluePrint.Core.Services;
using MobileBluePrint.Core.Interfaces;

namespace MobileBluePrint.ViewModels
{
    public class Page1ViewModel : BaseViewModel, IInitializable
    {
        public Page1ViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public Task Initialize<TParam>(TParam param)
        {
            return Task.Delay(1000);
        }
    }
}

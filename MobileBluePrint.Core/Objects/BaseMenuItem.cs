using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileBluePrint.Core.Objects
{
    public abstract class BaseMenuItem : IMasterPageMenuItem
    {
        private readonly IMasterPageService _masterPageService;
        public BaseMenuItem(IMasterPageService masterPageService)
        {
            _masterPageService = masterPageService;

            NavigateToRootPageCommand = new Command<string>((param) =>
            {
                _masterPageService.SetRootPage(param);
            });
        }

        public abstract bool IsDefault { get; }
        public abstract string ItemText { get; }
        public abstract string PageKey { get; }

        public ICommand NavigateToRootPageCommand { get; set; }
    }
}

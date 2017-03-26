using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBluePrint.ViewModels
{
    public class MainPageViewModel : BaseViewModel, IMainPageViewModel
    {
        public string TestProp
        {
            get
            {
                return "Test";
            }
        }
    }
}

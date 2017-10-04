using MobileBluePrint.CustomControls;
using MobileBluePrint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBluePrint
{
    //TODO: transfer to core?
    public partial class MainPage : CustomMasterDetail
    {
        public MainPage()
        {
            InitializeComponent();

           // BindingContext = new MainPageViewModel();
        }
    }
}

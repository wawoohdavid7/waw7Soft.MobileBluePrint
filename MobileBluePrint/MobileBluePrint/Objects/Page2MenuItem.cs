using MobileBluePrint.Constants;
using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.Objects;
using MobileBluePrint.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using BaseMenuItem = MobileBluePrint.Core.Objects.BaseMenuItem;
namespace MobileBluePrint.Objects
{
    public class Page2MenuItem : BaseMenuItem
    {
        public Page2MenuItem(IMasterPageService masterPageService)
            : base(masterPageService)
        {
        }

        public override bool IsDefault
        {
            get
            {
                return true;
            }
        }

        public override string ItemText
        {
            get
            {
                return "Navigate to Page 2";
            }
        }

        public override string PageKey
        {
            get
            {
                return ViewNames.Page2;
            }
        }

    }
}

using MobileBluePrint.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBluePrint.Core.Objects
{
    public class SelectionArguments
    {
        //public Action<IEnumerable<ISelectableItem>> NavigateToSelectionPage { get; set; }
        public Action NavigateAction { get; set; }
        public string Title { get; set; }
        public IEnumerable<ISelectableItem> ItemSource { get; set; }
    }
}

using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBluePrint.Core.ViewModels
{
    public class DropdownPageViewModel : BaseViewModel
    {
        public DropdownPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        private IEnumerable<ISelectableItem> _selectionList;
        public IEnumerable<ISelectableItem> SelectionList
        {
            get
            {
                return _selectionList;
            }
            set
            {
                Set<IEnumerable<ISelectableItem>>(ref _selectionList, value);
            }
        }
    }
}

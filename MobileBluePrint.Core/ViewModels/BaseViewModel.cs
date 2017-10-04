using MobileBluePrint.Core.Constants;
using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobileBluePrint.Core.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private readonly INavigationService _navigationService;
        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            //NavigateToDropdownPage = async (selectionList) => 
            //{
            //    //await _navigationService.PushPageAsync(CoreViewNames.Dropdown);
            //    await _navigationService.PushPageAsync(CoreViewNames.Dropdown, selectionList);
            //};
        }

        public virtual async Task NavigateToDropdownPage<TParam>(TParam param)
        {
            await _navigationService.PushPageAsync(CoreViewNames.Dropdown, param);
        }
        
        //public Action<IEnumerable<ISelectableItem>> NavigateToDropdownPage { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void Set<T>(ref T field, T newValue = default(T), [CallerMemberName]string propertyName = null)
        {
            if (field != null)
            {
                if (!field.Equals(newValue))
                {
                    field = newValue;
                    OnPropertyChanged(propertyName);
                }
            }
            else
            {
                if (newValue != null)
                {
                    field = newValue;
                    OnPropertyChanged(propertyName);
                }
            }

        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

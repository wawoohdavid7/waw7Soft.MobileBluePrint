using MobileBluePrint.Core.Interfaces;
using MobileBluePrint.Core.Objects;
using MobileBluePrint.Core.Services;
using MobileBluePrint.Core.ViewModels;
using MobileBluePrint.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//TODO: solve master page whole screen vertical height.
namespace MobileBluePrint.ViewModels
{
    public class MasterPageViewModel : BaseViewModel
    {
        private readonly IMasterPageService _masterPageService;
        public MasterPageViewModel(IMasterPageService masterPageService, INavigationService navigationService)
            : base(navigationService)
        {
            _masterPageService = masterPageService;
           _selectedMenuItem = getDefaultMenuItem();
            Testing = "Grrrw";
        }

        private IMasterPageMenuItem getDefaultMenuItem()
        {
            return MenuItemList.FirstOrDefault(f => f.IsDefault);
        }

        public List<IMasterPageMenuItem> MenuItemList
        {
            get
            {
                return _masterPageService.GetMenuItemList();
            }
        }

        private IMasterPageMenuItem _selectedMenuItem;
        public IMasterPageMenuItem SelectedMenuItem
        {
            get
            {
                return _selectedMenuItem;
            }
            set
            {
                //if (_selectedMenuItem.PageKey != value.PageKey)
                //{
                //    GoToPage();
                //}

                Set(ref _selectedMenuItem, value);
            }
        }

        private string _testing;
        public string Testing
        {
            get
            {
                return _testing;
            }
            set
            {
                Set(ref _testing, value);
            }
        }

        //private void GoToPage()
        //{
        //     _selectedMenuItem?.NavigateCommand.Execute(null);
        //}

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (IMasterPageMenuItem)e.SelectedItem;

            _masterPageService.SetRootPage(item.PageKey);
            //var item = e.SelectedItem as IMasterPageMenuItem;
            //if (item != null)
            //{
            //    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            //    masterPage.ListView.SelectedItem = null;
            //    IsPresented = false;
            //}
        }
    }
}

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

namespace MobileBluePrint.Core.ContentViews
{
    public partial class SingleSelectDropdown : ContentView
    {
        public SingleSelectDropdown()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty SelectionArgumentsProperty =
          BindableProperty.Create(nameof(SelectionArguments), typeof(SelectionArguments), typeof(SingleSelectDropdown), null);
        public SelectionArguments SelectionArguments
        {
            get
            {
                return (SelectionArguments)GetValue(SelectionArgumentsProperty);
            }
            set
            {
                SetValue(SelectionArgumentsProperty, value);
            }
        }

        public static readonly BindableProperty TapCommandProperty =
          BindableProperty.Create(nameof(TapCommand), typeof(ICommand), typeof(SingleSelectDropdown), null);
        public ICommand TapCommand
        {
            get
            {
                return (ICommand)GetValue(TapCommandProperty);
            }
            set
            {
                SetValue(TapCommandProperty, value);
            }
        }

        public static readonly BindableProperty SelectableItemListProperty =
          BindableProperty.Create(nameof(SelectableItemList), typeof(IEnumerable<ISelectableItem>), typeof(SingleSelectDropdown), null,BindingMode.TwoWay);
        public IEnumerable<ISelectableItem> SelectableItemList
        {
            get
            {
                return (IEnumerable<ISelectableItem>)GetValue(SelectableItemListProperty);
            }
            set
            {
                SetValue(SelectableItemListProperty, value);
            }
        }



        private void OnTapped(object sender, EventArgs args)
        {
            SelectionArguments.NavigateAction();
        }
    }
}

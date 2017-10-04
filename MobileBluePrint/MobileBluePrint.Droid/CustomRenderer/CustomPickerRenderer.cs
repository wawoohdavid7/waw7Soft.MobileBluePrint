using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MobileBluePrint.CustomControls;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using MobileBluePrint.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace MobileBluePrint.Droid.CustomRenderer
{
    public class CustomPickerRenderer : ViewRenderer<Xamarin.Forms.View,Spinner> 
    {
        Spinner _spinner;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);
            _spinner = new Spinner(Forms.Context);
            SetNativeControl(_spinner);
        }
    }
}
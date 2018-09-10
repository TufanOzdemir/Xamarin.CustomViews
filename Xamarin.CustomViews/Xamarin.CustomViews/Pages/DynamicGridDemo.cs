using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CustomViews.Views;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Pages
{
    public class DynamicGridDemo : ContentPage
    {
        public DynamicGridDemo()
        {
            ComponentLoad();
        }

        private void ComponentLoad()
        {
            DynamicGrid dynamicGrid = new DynamicGrid(Enums.DynamicGridEnum.Custom, 30, 20, 20, 30) { VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Aqua,   VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Black,  VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Violet, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Yellow, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Aquamarine, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 60 });
            Content = dynamicGrid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class PercentShowView : DynamicGrid
    {
        public PercentShowView(Color fillColor, Color emptyColor, int value) : base(Enums.DynamicGridEnum.Custom, value, 100 - value)
        {
            Margin = 0; Padding = 0;
            AddView(new BoxView() { BackgroundColor = fillColor, HeightRequest = 10 });
            AddView(new BoxView() { BackgroundColor = emptyColor, HeightRequest = 10 });
            VerticalOptions = LayoutOptions.CenterAndExpand;
            HorizontalOptions = LayoutOptions.FillAndExpand;
        }
    }
}

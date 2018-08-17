using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class PercentShowCardView : DynamicGrid
    {
        public PercentShowCardView(Color fullColor, Color emptyColor, int value, Color textColor, params int[] percent) : base(Enums.DynamicGridEnum.Custom, percent)
        {
            Padding = 0; Margin = 0;
            AddView(new PercentShowView(fullColor, emptyColor, value) { HeightRequest = 5 });
            AddView(new Label() { Text = $"%{value.ToString()}", FontAttributes = FontAttributes.Bold, Margin = 0, VerticalTextAlignment = TextAlignment.Center, HorizontalTextAlignment = TextAlignment.End, TextColor = textColor });
        }
    }
}

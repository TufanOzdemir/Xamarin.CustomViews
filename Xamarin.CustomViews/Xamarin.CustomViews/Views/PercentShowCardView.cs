using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class PercentShowCardView : DynamicGrid
    {
        public PercentShowCardView(PercentShowView percentShowView, string text, Color textColor, List<int> percent) : base(Enums.DynamicGridEnum.Custom, 2, percent)
        {
            Padding = 0; Margin = 0;
            AddView(percentShowView);
            AddView(new Label() { Text = text, FontAttributes = FontAttributes.Bold, Margin = 0, VerticalTextAlignment = TextAlignment.Center, HorizontalTextAlignment = TextAlignment.End, TextColor = textColor });
        }
    }
}

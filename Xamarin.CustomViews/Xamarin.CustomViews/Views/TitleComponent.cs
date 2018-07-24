using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class TitleComponent : StackLayout
    {
        public TitleComponent(string text)
        {
            Padding = 0;
            Label lbl = new Label
            {
                Text = text,
                TextColor = Color.FromHex("#3d454f"),
                FontFamily = "'Helvetica Neue','Segoe UI',Helvetica,Verdana,sans-serif",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Children.Add(lbl);
            Children.Add(new Line(Enums.LineEnum.Horizontal));
        }
    }
}

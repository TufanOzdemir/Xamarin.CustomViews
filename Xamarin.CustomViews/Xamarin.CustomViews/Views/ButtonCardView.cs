using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class ButtonCardView : StackLayout
    {
        public ButtonCardView(string text, string buttonImageUrl)
        {
            CircleImage btn = new CircleImage()
            {
                Source = buttonImageUrl + ".png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 80,
                HeightRequest = 80
            };

            Label lbl = new Label
            {
                Text = text,
                TextColor = Color.FromHex("#3d454f"),
                FontFamily = "'Helvetica Neue','Segoe UI',Helvetica,Verdana,sans-serif",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 10,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Children.Add(btn);
            Children.Add(lbl);
        }
    }
}

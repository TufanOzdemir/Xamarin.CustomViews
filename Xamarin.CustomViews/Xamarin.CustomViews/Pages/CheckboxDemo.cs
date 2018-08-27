using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CustomViews.Views;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Pages
{
    public class CheckboxDemo : ContentPage
    {
        public CheckboxDemo()
        {
            Content = new StackLayout()
            {
                Children =
                {
                    new CheckboxCardView("Hello"){ HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center }
                }
            };
        }
    }
}

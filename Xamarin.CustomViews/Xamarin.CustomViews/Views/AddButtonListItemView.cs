using System;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class AddButtonListItemView : StackLayout
    {
        public AddButtonListItemView(string text, int id, Action callback)
        {
            Orientation = StackOrientation.Horizontal;
            Button button = new Button() { Text = "+", CornerRadius = 40, WidthRequest = 80, HeightRequest = 80, Command = new Command(callback), CommandParameter = id };
            Label label = new Label() { Text = text};
            Children.Add(button);
            Children.Add(label);
        }
    }
}

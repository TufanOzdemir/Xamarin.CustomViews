using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class SnackBar : StackLayout
    {
        public SnackBar(string text, Color backColor)
        {
            VerticalOptions = LayoutOptions.Start;
            BackgroundColor = backColor;
            HeightRequest = 50;            
            Children.Add(new Label() { Text = text.Length >= 100 ? text.Substring(0,50) : text, Margin = new Thickness(20, 0, 5, 0), TextColor = Color.White, VerticalOptions = LayoutOptions.CenterAndExpand,HorizontalTextAlignment = TextAlignment.Center });
        }
    }
}

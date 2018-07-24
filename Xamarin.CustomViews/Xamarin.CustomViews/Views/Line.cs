using Xamarin.CustomViews.Enums;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class Line : BoxView
    {
        public Line(LineEnum lineType)
        {
            BackgroundColor = Color.Black;
            Color = Color.Black;
            if (lineType == LineEnum.Horizontal)
            {
                HeightRequest = 1;
                WidthRequest = 400;
                VerticalOptions = LayoutOptions.CenterAndExpand;
                HorizontalOptions = LayoutOptions.FillAndExpand;
            }
            else
            {
                HeightRequest = 400;
                WidthRequest = 1;
                VerticalOptions = LayoutOptions.FillAndExpand;
                HorizontalOptions = LayoutOptions.CenterAndExpand;
            }
        }
    }
}

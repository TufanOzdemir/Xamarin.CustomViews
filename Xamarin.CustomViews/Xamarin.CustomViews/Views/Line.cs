using Xamarin.CustomViews.Enums;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class Line : BoxView
    {
        LineEnum _lineType;
        public Line(LineEnum lineType)
        {
            _lineType = lineType;
            BackgroundColor = Color.Black;
            Initialize();
        }

        public Line(LineEnum lineType,Color color)
        {
            _lineType = lineType;
            BackgroundColor = color;
            Initialize();
        }

        private void Initialize()
        {
            switch (_lineType)
            {
                case LineEnum.Horizontal:
                    HorizontalLineInitialize();
                    break;
                case LineEnum.Vertical:
                    VerticalLineInitialize();
                    break;
                default:
                    break;
            }
        }

        private void HorizontalLineInitialize()
        {
            HeightRequest = 1;
            WidthRequest = 400;
            VerticalOptions = LayoutOptions.CenterAndExpand;
            HorizontalOptions = LayoutOptions.FillAndExpand;
        }

        private void VerticalLineInitialize()
        {
            HeightRequest = 400;
            WidthRequest = 1;
            VerticalOptions = LayoutOptions.FillAndExpand;
            HorizontalOptions = LayoutOptions.CenterAndExpand;
        }
    }
}

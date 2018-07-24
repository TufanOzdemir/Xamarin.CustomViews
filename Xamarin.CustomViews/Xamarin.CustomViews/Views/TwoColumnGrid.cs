using Xamarin.CustomViews.Enums;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class TwoColumnGrid : Grid
    {
        private int _count;
        private int _lineHeight;
        private int _starHeight;

        public TwoColumnGrid(int lineHeight = 0, int starHeight = 0)
        {
            _count = 0;
            _lineHeight = lineHeight;
            _starHeight = starHeight;
            Padding = 0;
            Margin = 0;
            ColumnSpacing = -1;
            RowSpacing = -1;
            ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(49, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(2, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(49, GridUnitType.Star) });
        }

        public void AddView(View view)
        {
            int countRow = _count / 2;
            if (RowDefinitions.Count <= countRow)
            {
                if (_starHeight > 0 )
                {
                    RowDefinitions.Add(new RowDefinition() { Height = new GridLength(_starHeight, GridUnitType.Star) });
                }
                else
                {
                    RowDefinitions.Add(new RowDefinition() { Height = new GridLength(50, GridUnitType.Auto) });
                }
                
                Children.Add(view, 0, countRow);
                Children.Add(new Line(LineEnum.Vertical) { Margin = _lineHeight > 0 ? new Thickness(1, _lineHeight, 1, _lineHeight) : _lineHeight, HeightRequest = 1 }, 1, countRow);
            }
            else
            {
                Children.Add(view, 2, countRow);
            }
            _count++;
        }
    }
}

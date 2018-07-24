using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class SliderDots : StackLayout
    {
        public SliderDots(int count)
        {
            Orientation = StackOrientation.Horizontal;
            HorizontalOptions = LayoutOptions.Center;
            VerticalOptions = LayoutOptions.Center;

            for (int l = 0; l < count; l++)
            {
                Button dotsBtn = new Button
                {
                    CornerRadius = 5,
                    HeightRequest = 8,
                    WidthRequest = 8,
                    Margin = 0,
                    BackgroundColor = Color.Black
                };
                if (l == 0)
                {
                    dotsBtn.BackgroundColor = Color.Orange;
                }
                Children.Add(dotsBtn);
            }
        }

        public void AddDots()
        {
            Button dotsBtn = new Button
            {
                CornerRadius = 5,
                HeightRequest = 8,
                WidthRequest = 8,
                Margin = 0,
                BackgroundColor = Color.Black
            };
            Children.Add(dotsBtn);
            if (Children.Count == 1)
            {
                dotsBtn.BackgroundColor = Color.Orange;
            }
        }

        public void RefreshDots(int count)
        {
            foreach (var item in Children)
            {
                item.BackgroundColor = Color.Black;
            }
            Children[count].BackgroundColor = Color.Orange;
        }
    }
}

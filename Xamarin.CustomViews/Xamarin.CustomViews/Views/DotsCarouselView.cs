using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class DotsCarouselView : StackLayout
    {
        SliderDots sliderDots;
        List<View> sourceList;
        CarouselView carouselView;
        public DotsCarouselView()
        {
            sourceList = new List<View>();
            carouselView = new CarouselView()
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    Image image = new Image();
                    image.SetBinding(Image.SourceProperty, "Source");
                    return image;
                }),
                WidthRequest = 600,
                HeightRequest = 200,
                Margin = 0
            };
            carouselView.ItemSelected += ScrollCarousel;
            carouselView.ItemsSource = sourceList;

            HorizontalOptions = LayoutOptions.Center;
            VerticalOptions = LayoutOptions.Center;
            Margin = 0;
            Padding = 0;

            sliderDots = new SliderDots(0);

            Children.Add(carouselView);
            Children.Add(sliderDots);
        }

        private void ScrollCarousel(object sender, SelectedItemChangedEventArgs e)
        {
            View view = (View)e.SelectedItem;
            sliderDots.RefreshDots(sourceList.IndexOf(view));
        }

        public void AddView(View view)
        {
            sourceList.Add(view);
            sliderDots.AddDots();
        }
    }
}

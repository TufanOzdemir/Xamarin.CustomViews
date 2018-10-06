using Xamarin.CustomViews.Enums;
using Xamarin.CustomViews.Views;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Pages
{
    public class PercentCardViewDemo : ContentPage
    {
        public PercentCardViewDemo()
        {
            StackLayout sl = new StackLayout();
            sl.Children.Add(GetItem(new ReportViewModel() { Name = "deneme0", Percent = 10, Value = 60 }));
            sl.Children.Add(GetItem(new ReportViewModel() { Name = "deneme1", Percent = 20, Value = 40 }));
            sl.Children.Add(GetItem(new ReportViewModel() { Name = "deneme2", Percent = 60, Value = 80 }));
            Content = sl;
        }

        private View GetItem(ReportViewModel model)
        {
            StackLayout sl = new StackLayout() { Padding = 0, Margin = 0, Spacing = 0 };
            DynamicGrid dynamicGrid = new DynamicGrid(DynamicGridEnum.Custom, 45, 55) { Padding = 0, HeightRequest = 20 };
            dynamicGrid.AddView(new Label() { Text = $"{model.Name}", HorizontalTextAlignment = TextAlignment.Start, VerticalTextAlignment = TextAlignment.Center, TextColor = Color.Black, Margin = 0 });
            dynamicGrid.AddView(new Label() { Text = $"{model.Value} TL", FontAttributes = FontAttributes.Bold, HorizontalTextAlignment = TextAlignment.Start, VerticalTextAlignment = TextAlignment.Center, Margin = 0, TextColor = Color.Black });
            sl.Children.Add(dynamicGrid);
            sl.Children.Add(new PercentShowCardView(Color.Green, Color.Red, model.Percent, Color.Black, 88, 12) { Margin = 0, Padding = 0 });
            sl.Children.Add(new Line(LineEnum.Horizontal) { Margin = new Thickness(0, 10, 0, 0) });
            return sl;
        }
    }
    public class ReportViewModel
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int Percent { get; set; }
    }
}

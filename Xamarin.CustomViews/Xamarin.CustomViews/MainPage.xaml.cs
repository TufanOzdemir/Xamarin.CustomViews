using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CustomViews.Views;
using Xamarin.Forms;

namespace Xamarin.CustomViews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout sl = new StackLayout();
            DynamicGrid dynamicGrid = new DynamicGrid(Enums.DynamicGridEnum.Custom, 20, 50, 20, 0);
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.AliceBlue });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Aqua });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.AntiqueWhite });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Azure });
            sl.Children.Add(new PercentShowCardView(Color.Beige, Color.Bisque, 60, Color.Black, 90, 10));
            sl.Children.Add(dynamicGrid);
            Content = sl;
        }
    }
}

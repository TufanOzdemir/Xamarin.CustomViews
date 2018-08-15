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
            sl.Children.Add(new PercentShowCardView(new PercentShowView(Color.Green, Color.Wheat, 60) { HeightRequest = 5 }, "%60", Color.Aqua, new List<int>() { 90, 10 }));
            Content = sl;
        }
    }
}

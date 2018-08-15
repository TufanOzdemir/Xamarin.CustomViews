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
            DynamicGrid dynamicGrid = new DynamicGrid(Enums.DynamicGridEnum.Auto, 4);
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Green });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Red });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Blue });
            dynamicGrid.AddView(new BoxView() { BackgroundColor = Color.Black });
            Content = dynamicGrid;
        }
    }
}

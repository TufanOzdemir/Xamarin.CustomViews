using System;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class BottomFooterBarItem : Frame
    {
        public BottomFooterBarItem(View view, string informationMessage, Action Callback)
        {
            BorderColor = Color.Black;
            Padding = 5;
            Margin = 0;
            Content = new StackLayout
            {
                Margin = 0,
                Padding = 0,
                Spacing = 0,
                Children =
                {
                    view,
                    new Label
                    {
                        Text = informationMessage,
                        HorizontalTextAlignment = TextAlignment.Center,
                        TextColor = Color.Black,
                        FontSize = 8
                    }
                }
            };
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s,e) => { Callback.Invoke(); };

            GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}

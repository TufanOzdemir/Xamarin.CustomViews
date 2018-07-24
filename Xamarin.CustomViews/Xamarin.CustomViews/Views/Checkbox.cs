using System;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class Checkbox : Frame
    {
        public bool isChecked { get; set; }
        Image checkImage;
        Action _callback;

        public Checkbox()
        {
            ViewLoad();
        }
        public Checkbox(Action callback)
        {
            _callback = callback;
            ViewLoad();
        }

        private void ViewLoad()
        {
            MinimumHeightRequest = 20;
            MinimumWidthRequest = 20;
            BorderColor = Color.Black;
            WidthRequest = 20;
            HeightRequest = 20;
            Padding = 0;
            Margin = 0;
            BackgroundColor = Color.White;
            checkImage = new Image
            {
                Source = "check.png",
                IsVisible = isChecked,
                WidthRequest = 20,
                HeightRequest = 20
            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += SetCheck;
            GestureRecognizers.Add(tap);
            Content = checkImage;
        }

        public virtual void SetCheck(object sender, EventArgs e)
        {
            isChecked = !isChecked;
            checkImage.IsVisible = isChecked;
            if (_callback != null)
            {
                _callback.Invoke();
            }
        }
    }
}

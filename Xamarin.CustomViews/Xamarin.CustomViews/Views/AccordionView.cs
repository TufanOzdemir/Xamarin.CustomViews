using Xamarin.CustomViews.Enums;
using System;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class AccordionView : StackLayout
    {
        public Label StateLabel { get; set; }
        public string TitleText { get; set; }
        public bool IsShow { get; set; }
        private View viewStack;

        public AccordionView(string title,View views)
        {
            viewStack = views;
            viewStack.IsVisible = false;
            Margin = 0;
            Padding = 5;
            TitleText = title;
            StateLabel = new Label() { Text = "+" };
            Children.Add(MainGrid());
            Children.Add(new Line(LineEnum.Horizontal));
            Children.Add(viewStack);
        }

        private Grid MainGrid()
        {
            Grid grid = new Grid()
            {
                RowDefinitions =
                {
                    new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition() { Width = new GridLength(90, GridUnitType.Star) },
                    new ColumnDefinition() { Width = new GridLength(10, GridUnitType.Star) }
                }
            };

            grid.Children.Add(new Label() { Text = TitleText }, 0, 0);
            grid.Children.Add(StateLabel, 1, 0);
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += ShowHide;
            grid.GestureRecognizers.Add(tapGestureRecognizer);
            return grid;
        }

        private void ShowHide(object sender, EventArgs e)
        {
            IsShow = !IsShow;
            viewStack.IsVisible = IsShow;
            StateLabel.Text = IsShow ? "-" : "+";
        }
    }
}

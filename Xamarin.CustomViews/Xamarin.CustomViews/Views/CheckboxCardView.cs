using System;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class CheckboxCardView : Frame
    {
        public Color LabelColor { get; set; }
        public bool IsChecked { get; set; }

        private StackLayout mainStack { get; set; }
        private Label CardLabel { get; set; }
        private Checkbox CardCheckbox { get; set; }
        private Action _action;

        public CheckboxCardView(Action action = null)
        {
            CardLabel = new Label() { TextColor = Color.Gray };
            ViewLoad(action);
        }

        public CheckboxCardView(string text, Action action = null)
        {
            CardLabel = new Label() { Text = text, TextColor = Color.Gray };
            ViewLoad(action);
        }

        public CheckboxCardView(string text, string font, Action action = null)
        {
            CardLabel = new Label() { Text = text, TextColor = Color.Gray, FontFamily = font };
            ViewLoad(action);
        }

        private void ViewLoad(Action action)
        {
            Padding = 0;
            Margin = 0;
            HasShadow = false;
            mainStack = new StackLayout() { Orientation = StackOrientation.Horizontal, Padding = 0, Margin = 0 };
            Content = mainStack;
            _action = action;
            LabelColor = Color.Red;
            CardCheckbox = new Checkbox(Check);
            mainStack.Children.Add(CardCheckbox);
            mainStack.Children.Add(CardLabel);
        }

        public void Check()
        {
            CardLabel.TextColor = CardCheckbox.isChecked ? LabelColor : Color.Gray;
            IsChecked = CardCheckbox.isChecked;
            if (_action != null)
            {
                _action.Invoke();
            }
        }
    }
}

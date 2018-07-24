using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class CheckboxCardView : StackLayout
    {
        public Color LabelColor { get; set; }
        public bool IsChecked { get; set; }

        private Label CardLabel { get; set; }
        private Checkbox CardCheckbox { get; set; }

        public CheckboxCardView()
        {
            CardLabel = new Label() {TextColor = Color.Gray };
            ViewLoad();
        }

        public CheckboxCardView(string text)
        {
            CardLabel = new Label() { Text = text, TextColor = Color.Gray };
            ViewLoad();
        }

        public CheckboxCardView(string text, string font)
        {
            CardLabel = new Label() { Text = text, TextColor = Color.Gray, FontFamily = font };
            ViewLoad();
        }

        private void ViewLoad()
        {
            LabelColor = Color.Red;
            CardCheckbox = new Checkbox(Check);
            Orientation = StackOrientation.Horizontal;
            Children.Add(CardCheckbox);
            Children.Add(CardLabel);
        }

        public void Check()
        {
            CardLabel.TextColor = CardCheckbox.isChecked ? LabelColor : Color.Gray;
            IsChecked = CardCheckbox.isChecked;
        }
    }
}

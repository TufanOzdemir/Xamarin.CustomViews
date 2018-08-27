using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CustomViews.Views;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Pages
{
    public class FormDemo : ContentPage
    {
        GenericForm<FormViewModel> _genericForm;
        FormViewModel _model;
        public FormDemo()
        {
            Title = "Satış";
            ComponentLoad();
        }

        private void ComponentLoad()
        {
            _model = new FormViewModel();
            ScrollView scrollView = new ScrollView();
            Frame mainFrame = new Frame() { BorderColor = Color.Black, Padding = 5, Margin = 2 };
            StackLayout mainStackLayout = new StackLayout() { Padding = 0, Spacing = 10 };
            _genericForm = new GenericForm<FormViewModel>("Başlık");
            mainStackLayout.Children.Add(_genericForm);
            mainFrame.Content = mainStackLayout;
            scrollView.Content = mainFrame;
            _genericForm.AddView(GetFormContent());
            _genericForm.AddView(GetFormOtherComponent());
            _genericForm.AddView(GetFormFooter());
            _genericForm.FinishForm(FormSerialize, CancelForm);
            Content = scrollView;
        }

        private void FormSerialize()
        {
            var form = _genericForm.Serialize();
        }

        private void CancelForm()
        {
            Navigation.PopAsync();
        }

        private View GetFormFooter()
        {
            StackLayout stack = new StackLayout() { Margin = 0, Padding = 0 };
            stack.Children.Add(new CheckboxCardView("Kullanım Koşulları") { ClassId = nameof(_model.Policy) });
            return stack;
        }

        private View GetFormHeader()
        {
            return new Label() { Text = "Satış Formu", FontAttributes = FontAttributes.Bold, FontSize = 25, HorizontalTextAlignment = TextAlignment.Center };
        }

        private StackLayout GetFormOtherComponent()
        {
            StackLayout stack = new StackLayout() { Margin = 0, Padding = 0 };
            stack.Children.Add(new Entry() { Placeholder = "E-Mail", ClassId = nameof(_model.Mail) });
            stack.Children.Add(new Entry() { Placeholder = "Adres", ClassId = nameof(_model.Address) });
            return stack;
        }

        private DynamicGrid GetFormContent()
        {
            DynamicGrid dynamicGrid = new DynamicGrid(Enums.DynamicGridEnum.Star, 2, 50) { ColumnSpacing = 5, RowSpacing = 5 };
            dynamicGrid.AddView(new Entry() { Placeholder = "Ad-Soyad", ClassId = nameof(_model.Name) });
            dynamicGrid.AddView(new Entry() { Placeholder = "Telefon", ClassId = nameof(_model.Phone) });
            dynamicGrid.AddView(new Picker() { ItemsSource = new List<string>() { "Malatya", "Istanbul" }, Title = "İl", ClassId = nameof(_model.City) });
            dynamicGrid.AddView(new Picker() { ItemsSource = new List<string>() { "Babıhtı", "Çırmıhtı" }, Title = "İlçe", ClassId = nameof(_model.District) });
            return dynamicGrid;
        }
    }
    class FormViewModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public bool Policy { get; set; }
    }
}

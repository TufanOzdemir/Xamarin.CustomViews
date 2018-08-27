using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.CustomViews.Enums;
using Xamarin.Forms;

namespace Xamarin.CustomViews.Views
{
    public class GenericForm<T> : StackLayout where T : class, new()
    {
        Action _callback;
        T _model;
        private string _formTitle;
        private HeaderOptions _headerOptions;
        private StackLayout _contentStack;

        public GenericForm(string title, HeaderOptions headerOptions = null)
        {
            _model = new T();
            _formTitle = title;
            _headerOptions = headerOptions == null ? _headerOptions = new HeaderOptions() : headerOptions;
            FormInitialize();
        }

        private void FormInitialize()
        {
            _contentStack = new StackLayout();
            Children.Add(GetHeader());
            Children.Add(_contentStack);
        }

        public void AddView(View formView)
        {
            _contentStack.Children.Add(formView);
        }

        private View GetHeader()
        {
            Label headerLabel = new Label() { Text = _formTitle, TextColor = _headerOptions.TextColor, FontAttributes = _headerOptions.FontAttributes, FontSize = _headerOptions.FontSize, VerticalTextAlignment = _headerOptions.TextAlignment };
            return headerLabel;
        }

        public void FinishForm(Action okMethod, Action cancelMethod)
        {
            _callback = okMethod;
            DynamicGrid footerDynamicGrid = new DynamicGrid(DynamicGridEnum.Star, 2, 50);
            footerDynamicGrid.AddView(new Button() { Text = "Geri Dön", Command = new Command(cancelMethod) });
            footerDynamicGrid.AddView(new Button() { Text = "Devam Et", Command = new Command(Execute) });
            Children.Add(footerDynamicGrid);
        }

        private void Execute(object obj)
        {
            foreach (var item in Children)
            {
                TypeMapping(item);
            }
            _callback.Invoke();
        }

        private void TypeMapping(View item)
        {
            try
            {
                if (typeof(IViewContainer<View>).IsAssignableFrom(item.GetType()))
                {
                    Layout<View> layout = (Layout<View>)item;

                    foreach (var child in layout.Children)
                    {
                        TypeMapping(child);
                    }
                }
                else
                {
                    View view = (View)item;
                    Process(view);
                }
            }
            catch
            {
                return;
            }
        }

        private void Process(View view)
        {
            if (!string.IsNullOrWhiteSpace(view.ClassId))
            {
                Type itemType = view.GetType();
                PropertyInfo pinfo = typeof(T).GetProperty(view.ClassId);
                if (typeof(Entry).IsAssignableFrom(itemType))
                {
                    var entry = (Entry)view;
                    pinfo.SetValue(_model, entry.Text);
                }
                else if (typeof(Picker).IsAssignableFrom(itemType))
                {
                    var picker = (Picker)view;
                    pinfo.SetValue(_model, picker.SelectedItem);
                }
                else if (typeof(CheckboxCardView).IsAssignableFrom(itemType))
                {
                    var checkbox = (CheckboxCardView)view;
                    pinfo.SetValue(_model, checkbox.IsChecked);
                }
            }
        }

        public T Serialize()
        {
            return _model;
        }
    }

    public class HeaderOptions
    {
        public Color TextColor { get; set; }
        public FontAttributes FontAttributes { get; set; }
        public int FontSize { get; set; }
        public TextAlignment TextAlignment { get; set; }

        public HeaderOptions()
        {
            TextColor = Color.Black;
            FontAttributes = FontAttributes.Bold;
            FontSize = 15;
            TextAlignment = TextAlignment.Center;
        }
    }
}

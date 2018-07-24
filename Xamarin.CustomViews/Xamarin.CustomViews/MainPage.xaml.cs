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
            Content = new StackLayout()
            {
                Children =
                {
                    new Checkbox(),
                    new CheckboxCardView("CheckboxCardView"),
                    new AccordionView("Accordion View",new Label(){ Text = "asd" }),
                    new ButtonCardView("ButtonCardView","Icon"),
                    new Line(Enums.LineEnum.Horizontal),
                    new TitleComponent("Title Component"),
                    new SnackBar("SnackBar",Color.Green)
                }
            };
		}
	}
}

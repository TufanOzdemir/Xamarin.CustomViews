using System;
using Xamarin.CustomViews.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Xamarin.CustomViews
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new PercentCardViewDemo();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

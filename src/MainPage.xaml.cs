using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace DarkLightMode
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;
			CounterLabel.Text = $"Current count: {count}";

			SemanticScreenReader.Announce(CounterLabel.Text);
		}

		void LightModeClicked(object sender, EventArgs eventArgs)
        {
			MainThread.InvokeOnMainThreadAsync(() =>
			{
				App.Current.UserAppTheme = OSAppTheme.Light;

			});
        }
		
		void DarkModeClicked(object sender, EventArgs eventArgs)
        {
			MainThread.InvokeOnMainThreadAsync(() =>
			{
				App.Current.UserAppTheme = OSAppTheme.Dark;

			});
		}
	}
}

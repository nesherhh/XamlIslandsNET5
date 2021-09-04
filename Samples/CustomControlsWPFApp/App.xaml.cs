using System;
using System.Windows;

namespace CustomControlsWPFApp
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App
	{
		public App()
		{
			Startup += OnStartup;
		}

		private void OnStartup(object sender, StartupEventArgs e)
		{
			var window = new MainWindow();
			window.Show();
		}
	}
}

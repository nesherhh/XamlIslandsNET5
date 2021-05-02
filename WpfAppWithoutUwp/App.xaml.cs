using System;
using System.Windows;
using Windows.UI.Xaml.Hosting;

namespace WpfAppWithoutUwp
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			WindowsXamlManager.InitializeForCurrentThread();
		}
	}
}

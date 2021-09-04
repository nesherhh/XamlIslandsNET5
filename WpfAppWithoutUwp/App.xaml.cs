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
			WindowsXamlManager.InitializeForCurrentThread();

			base.OnStartup(e);

			// C# UWP don't work :(
			//var class1 = new Class1();
			//var hudControl = new HudControl();

		}
	}
}

using System;
using System.Windows;
using CustomControls;

namespace CustomControlsWPFApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
		{
			var customControl1 = new CustomControl1();
			XamlHost.Child = customControl1;
		}
	}
}

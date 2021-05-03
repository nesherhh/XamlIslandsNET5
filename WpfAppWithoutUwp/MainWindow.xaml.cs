using System;
using Microsoft.Toolkit.Wpf.UI.XamlHost;

namespace WpfAppWithoutUwp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void WindowsXamlHostBase_OnChildChanged(object? sender, EventArgs e)
		{
			switch (sender)
			{
				case WindowsXamlHost xamlHost when xamlHost.GetUwpInternalObject() is Windows.UI.Xaml.Controls.Button button:
					button.Content = "UWP Button";
					break;
			}
		}
	}
}
using System;
using System.Windows;
using Microsoft.Toolkit.Wpf.UI.XamlHost;
using windows = Windows;


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

		private async void myMap_Loaded(object sender, RoutedEventArgs e)
		{
			if (myMap.Layers.Count == 0)
			{
				// Specify a known location.
				var cityPosition = new windows.Devices.Geolocation.BasicGeoposition()
				{
					Latitude = 47.604,
					Longitude = -122.329
				};
				var cityCenter = new windows.Devices.Geolocation.Geopoint(cityPosition);
				var icon = new windows.UI.Xaml.Controls.Maps.MapIcon()
				{
					Location = cityCenter,
				};

				var elements = new System.Collections.Generic.List<windows.UI.Xaml.Controls.Maps.MapElement>()
				{
					icon,
				};
				var layer = new windows.UI.Xaml.Controls.Maps.MapElementsLayer()
				{
					ZIndex = 1,
					MapElements = elements,
				};
				myMap.Layers.Add(layer);

				// Set the map location.
				await myMap.TrySetViewAsync(cityCenter, 12).ConfigureAwait(false);
			}
		}

	}
}
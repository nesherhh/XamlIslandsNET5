using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using CustomControls;
using RoutedEventArgs = System.Windows.RoutedEventArgs;
using Window = System.Windows.Window;

namespace CustomControlsWPFApp;

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

		customControl1.SetBinding(CustomControl1.HeadingProperty, new Binding
		{
			Source = vm,
			Path = new PropertyPath(nameof(ViewModel.Heading))
		});
	}
}
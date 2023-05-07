using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;

namespace CustomControls;

public sealed class CustomControl1 : Control
{
	private MapControl? _mapControl;

	public double Heading
	{
		get => (double) GetValue(HeadingProperty);
		set => SetValue(HeadingProperty, value);
	}

	public static readonly DependencyProperty HeadingProperty = DependencyProperty.Register(nameof(Heading), typeof(double), typeof(CustomControl1),
		new PropertyMetadata(0,
			PropertyChangedCallback));

	private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		var customControl1 = (CustomControl1) d;
		if (customControl1._mapControl is not null) 
			customControl1._mapControl.Heading = (double) e.NewValue;
	}

	public CustomControl1()
	{
		DefaultStyleKey = typeof(CustomControl1);
	}

	protected override void OnApplyTemplate()
	{
		base.OnApplyTemplate();

		_mapControl = (MapControl) GetTemplateChild("PART_Map");
	}
}
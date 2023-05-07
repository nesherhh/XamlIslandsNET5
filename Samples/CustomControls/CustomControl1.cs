using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Data;

namespace CustomControls;

public sealed class CustomControl1 : Control
{
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
		Trace.WriteLine($"CustomControl1 - Heading - {e.NewValue}");
	}


	public CustomControl1()
	{
		DefaultStyleKey = typeof(CustomControl1);
	}

	protected override void OnApplyTemplate()
	{
		base.OnApplyTemplate();

		//var mapControl = (MapControl)GetTemplateChild("PART_Map");
		//mapControl.SetBinding(MapControl.HeadingProperty, new Binding
		//{
		//	Source = this,
		//	Path = new PropertyPath(nameof(Heading))
		//});

		//var textBlock = (TextBlock)GetTemplateChild("PART_Text");
		//textBlock.SetBinding(TextBlock.TextProperty, new Binding
		//{
		//	Source = this,
		//	Path = new PropertyPath(nameof(Heading))
		//});
	}
}
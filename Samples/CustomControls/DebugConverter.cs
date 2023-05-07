using System;
using Windows.UI.Xaml.Data;

namespace CustomControls;

public sealed class DebugConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, string language)
	{
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, string language)
	{
		return value;
	}
}
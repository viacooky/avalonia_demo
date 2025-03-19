using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;
using AvaloniaDemo.Shared.Services;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace AvaloniaDemo.Converters;

public class IconConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var icons = Ioc.Default.GetRequiredService<IconService>();
        if (value is string key) return icons.GetIcon(key) ?? AvaloniaProperty.UnsetValue;

        return AvaloniaProperty.UnsetValue;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return AvaloniaProperty.UnsetValue;
    }
}
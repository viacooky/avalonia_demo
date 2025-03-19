using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaDemo.Shared.Services;
using AvaloniaDemo.Shared.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace AvaloniaDemo.DataTemplates;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        if (param is null) return null;

        var menuService = Ioc.Default.GetRequiredService<MenuService>();
        var viewType = menuService.MenuItems
            .FirstOrDefault(m => m.ViewModelType == param.GetType())
            ?.ViewType;

        if (viewType is null) return new TextBlock { Text = "ViewType Not Found: " };

        return (Control)Activator.CreateInstance(viewType);
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}
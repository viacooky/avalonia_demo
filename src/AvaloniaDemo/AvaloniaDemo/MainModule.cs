using System.Collections.ObjectModel;
using Avalonia.Controls;
using AvaloniaDemo.Services;
using AvaloniaDemo.ViewModels;
using AvaloniaDemo.Views;
using Microsoft.Extensions.DependencyInjection;
using MenuItem = AvaloniaDemo.Models.MenuItem;

namespace AvaloniaDemo;

public class MainModule
{
    public static void Init(ServiceCollection services,MenuService menuService)
    {
        menuService.AddMenu(new MenuItem { Key = "Override", Name = "Override", Icon = "SemiIconAlarm", });
        menuService.AddMenu(new MenuItem { Key = "menu1", Name = "menu1", Icon = "SemiIconAlarm",Children = new ObservableCollection<MenuItem>()
        {
            new() { Key = "menu1-1", Name = "menu1-1"},
            new() { Key = "menu1-2", Name = "menu1-2"},
            new() { Key = "menu1-3", Name = "menu1-3"},
        }});
        
        
        var mainWindow = new MainWindow() { DataContext = new MainViewModel() };
        services.AddSingleton(mainWindow);
    }
}
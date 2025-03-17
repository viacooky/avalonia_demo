using System.Collections.ObjectModel;
using AvaloniaDemo.Models;
using AvaloniaDemo.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace AvaloniaDemo.ViewModels;

public partial class MenuViewModel: ViewModelBase
{
    [ObservableProperty] private bool _isCollapsed;
    
    [ObservableProperty]
    private ObservableCollection<MenuItem>? _menuItems = Ioc.Default.GetRequiredService<MenuService>().MenuItems;
}
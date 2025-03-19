using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using AvaloniaDemo.Shared.Models;
using AvaloniaDemo.Shared.Services;
using AvaloniaDemo.Shared.ViewModels;
using AvaloniaDemo.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaDemo.ViewModels;

public partial class MenuViewModel : ViewModelBase
{
    [ObservableProperty] private bool _isCollapsed;

    [ObservableProperty]
    private ObservableCollection<MenuItem>? _menuItems = Ioc.Default.GetRequiredService<MenuService>().MenuItems;

    [RelayCommand]
    private void OpenSettings()
    {
        if (Application.Current?.ApplicationLifetime is not IClassicDesktopStyleApplicationLifetime desktop) return;
        if (desktop.MainWindow == null) return;
        new SettingsWindow().ShowDialog(desktop.MainWindow);
    }
}
using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using AvaloniaDemo.Services;
using AvaloniaDemo.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaDemo.ViewModels;

public partial class TitleBarViewModel:ViewModelBase
{
    [ObservableProperty] private string _test = "dddd";
    // [ObservableProperty]
    // private AppSettingsService _settings;
    //
    // // private readonly MainWindow? _window = Ioc.Default.GetService<MainWindow>();
    //
    // [RelayCommand]
    // private async Task OpenGithubUrl()
    // {
    //     // if (_window == null) return;
    //     // await _window.Launcher.LaunchUriAsync(new Uri(Settings.TitleBarGithubUrl));
    // }
}
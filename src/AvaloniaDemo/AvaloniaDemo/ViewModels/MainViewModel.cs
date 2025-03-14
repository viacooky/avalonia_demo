using System;
using AvaloniaDemo.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaDemo.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _greeting = AppSettings.AppName;


    [RelayCommand]
    private void OpenUrl()
    {
        var window = Ioc.Default.GetService<MainWindow>();
        window?.Launcher.LaunchUriAsync(new Uri(AppSettings.TitleBarGithubUrl));
    }
}
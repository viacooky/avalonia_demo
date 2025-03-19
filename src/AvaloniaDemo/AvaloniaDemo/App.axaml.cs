using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using AvaloniaDemo.Modules.Sample;
using AvaloniaDemo.Shared.Extensions;
using AvaloniaDemo.Shared.Services;
using AvaloniaDemo.ViewModels;
using AvaloniaDemo.Views;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaDemo;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    /// <summary>
    ///     初始化服务
    /// </summary>
    /// <param name="services"></param>
    private void InitService()
    {
        var menuService = new MenuService();
        var provider = new ServiceCollection()
            .AddSingleton(menuService) 
            .InitModule<MainModule>(menuService) // 主模块
            .InitModule<SampleModule>(menuService) // sample 模块
            .BuildServiceProvider();

        Ioc.Default.ConfigureServices(provider);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        InitService();

        var mainWindow = new MainWindow { DataContext = Ioc.Default.GetRequiredService<MainViewModel>() };
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();

            if (AppSettings.WelcomeWindowEnable)
            {
                desktop.MainWindow = new WelcomeWindow(mainWindow)
                {
                    DataContext = Ioc.Default.GetRequiredService<WelcomeWindowViewModel>()
                };
            }
            else
            {
                desktop.MainWindow = mainWindow;
            }
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = mainWindow;
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove) BindingPlugins.DataValidators.Remove(plugin);
    }

    private void ShowWindow_OnClicked(object? sender, EventArgs e)
    {
        if (ApplicationLifetime is not IClassicDesktopStyleApplicationLifetime desktop) return;
        desktop.MainWindow?.Show();
        desktop.MainWindow?.Activate();
    }

    private void ExitApp_OnClicked(object? sender, EventArgs e)
    {
        Environment.Exit(0);
    }
}
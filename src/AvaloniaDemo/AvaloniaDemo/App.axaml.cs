using System.Linq;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using AvaloniaDemo.Services;
using AvaloniaDemo.ViewModels;
using AvaloniaDemo.Views;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaDemo;

public partial class App : Application
{
    private ServiceCollection _services = new();

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    /// <summary>
    /// 初始化服务
    /// </summary>
    /// <param name="services"></param>
    private void InitService(ServiceCollection services)
    {
        var menuService = new MenuService();
        services.AddSingleton(menuService);//菜单服务
        MainModule.Init(services,menuService);
    }

    /// <summary>
    /// 初始化模块
    /// </summary>
    /// <param name="services"></param>
    private void InitModule(ServiceCollection services)
    {
        
    }

    public override void OnFrameworkInitializationCompleted()
    {
        #region 注册服务

        InitService(_services);
        Ioc.Default.ConfigureServices(_services.BuildServiceProvider());

        #endregion

        
        var mainWindow = Ioc.Default.GetRequiredService<MainWindow>();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();

            if (AppSettings.WelcomeWindowEnable)
                desktop.MainWindow = new WelcomeWindow() { DataContext = new WelcomeWindowViewModel() };
            else
                desktop.MainWindow = mainWindow;
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
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}
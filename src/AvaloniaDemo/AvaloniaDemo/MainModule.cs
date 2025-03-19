using AvaloniaDemo.Shared;
using AvaloniaDemo.Shared.Services;
using AvaloniaDemo.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaDemo;

public class MainModule : ModuleBase
{
    public override IServiceCollection ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IconService>(); //icon服务

        services.AddSingleton<MainViewModel>();
        services.AddSingleton<WelcomeWindowViewModel>();

        return base.ConfigureServices(services);
    }

    public override void ConfigureMenuService(MenuService menuService)
    {
    }
}
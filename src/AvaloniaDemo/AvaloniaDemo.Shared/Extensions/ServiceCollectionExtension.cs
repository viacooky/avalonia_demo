using AvaloniaDemo.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaDemo.Shared.Extensions;

public static class ServiceCollectionExtension
{
    /// <summary>
    /// 初始化模块
    /// </summary>
    /// <param name="services"></param>
    /// <param name="menuService"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static IServiceCollection InitModule<T>(this IServiceCollection services, MenuService menuService)
        where T : ModuleBase, new()
    {
        var module = new T();
        services = module.ConfigureServices(services);
        module.ConfigureMenuService(menuService);
        return services;
    }
}
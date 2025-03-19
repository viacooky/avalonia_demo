using System;
using AvaloniaDemo.Shared.Services;
using Microsoft.Extensions.DependencyInjection;


namespace AvaloniaDemo.Shared;

public class ModuleBase
{
    public virtual IServiceCollection ConfigureServices(IServiceCollection services)
    {
        return services;
    }

    public virtual void ConfigureMenuService(MenuService menuService)
    {
        
    }
}
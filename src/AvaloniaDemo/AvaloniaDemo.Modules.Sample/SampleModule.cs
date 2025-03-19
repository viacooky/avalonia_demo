using AvaloniaDemo.Modules.Sample.ViewModels;
using AvaloniaDemo.Modules.Sample.Views;
using AvaloniaDemo.Shared;
using AvaloniaDemo.Shared.Models;
using AvaloniaDemo.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaDemo.Modules.Sample;

public class SampleModule : ModuleBase
{
    public override IServiceCollection ConfigureServices(IServiceCollection services)
    {
        services
            .AddSingleton<OverrideViewModel>()
            .AddSingleton<ManagedFileViewModel>();
        return base.ConfigureServices(services);
    }

    public override void ConfigureMenuService(MenuService menuService)
    {
        menuService
            .AddMenu(new MenuItem
            {
                Key = "Override", Name = "Override", Icon = "SemiIconAlarm",
                ViewModelType = typeof(OverrideViewModel),
                ViewType = typeof(OverrideView)
            })
            .AddMenu(new MenuItem
            {
                Key = "ManagedFile", Name = "文件/目录选择", Icon = "SemiIconFile",
                ViewModelType = typeof(ManagedFileViewModel),
                ViewType = typeof(ManagedFileView)
            });

        base.ConfigureMenuService(menuService);
    }
}
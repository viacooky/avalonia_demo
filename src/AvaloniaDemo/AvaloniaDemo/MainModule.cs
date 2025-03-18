using AvaloniaDemo.Services;
using AvaloniaDemo.ViewModels.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using MenuItem = AvaloniaDemo.Models.MenuItem;

namespace AvaloniaDemo;

public class MainModule
{
    public static void Init(ServiceCollection services, MenuService menuService)
    {
        // 添加VM
        services.AddSingleton(new OverrideViewModel());

        // 添加菜单
        menuService.AddMenu(new MenuItem
        {
            Key = "Override", Name = "Override", Icon = "SemiIconAlarm",
            ViewModelType = "AvaloniaDemo.ViewModels.Pages.OverrideViewModel"
        });
        menuService.AddMenu(new MenuItem
        {
            Key = "menu1", Name = "menu1", Icon = "SemiIconAlarm", Children =
            [
                new() { Key = "menu1-1", Name = "menu1-1" },
                new()
                {
                    Key = "menu1-2", Name = "menu1-2",
                    ViewModelType = "AvaloniaDemo.ViewModels.Pages.OverrideViewModel"
                },
                new() { Key = "menu1-3", Name = "menu1-3" }
            ]
        });
    }
}
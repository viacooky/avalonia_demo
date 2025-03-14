using System;
using Avalonia.Threading;
using AvaloniaDemo.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using Irihi.Avalonia.Shared.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaDemo.ViewModels;

public partial class WelcomeWindowViewModel:ObservableObject, IDialogContext
{
    [ObservableProperty]
    private AppSettingsService _settings = App.Current.Services.GetRequiredService<AppSettingsService>();
    
    [ObservableProperty] private double _progress;
    
    private Random _r = new();

    public WelcomeWindowViewModel()
    {
        DispatcherTimer.Run(OnUpdate, TimeSpan.FromMilliseconds(20), DispatcherPriority.Default);
    }
    
    private bool OnUpdate()
    {
        // 可以在这里加入耗时的初始化操作
        // ...
        
        Progress += Settings.WelcomeWindowLoadingSpeed * _r.NextDouble();
        if (Progress <= 100)
        {
            return true;
        }
        else
        {
            RequestClose?.Invoke(this, true);
            return false;
        }
    }
    
    public void Close()
    {
        RequestClose?.Invoke(this, false);
    }
    
    public event EventHandler<object?>? RequestClose;
}
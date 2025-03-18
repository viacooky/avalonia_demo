using System;
using Avalonia.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using Irihi.Avalonia.Shared.Contracts;

namespace AvaloniaDemo.ViewModels;

public partial class WelcomeWindowViewModel : ObservableObject, IDialogContext
{
    [ObservableProperty] private string _title = AppSettings.WelcomeWindowTitle;
    [ObservableProperty] private string _subTitle = AppSettings.WelcomeWindowSubTitle;
    [ObservableProperty] private string _loading = AppSettings.WelcomeWindowLoadingStr;
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

        Progress += AppSettings.WelcomeWindowLoadingSpeed * _r.NextDouble();
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
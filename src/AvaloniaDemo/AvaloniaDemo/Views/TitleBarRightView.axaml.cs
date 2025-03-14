using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaDemo.Views;

public partial class TitleBarRightView : UserControl
{
    public TitleBarRightView()
    {
        InitializeComponent();
    }

    private async void OpenRepo(object? sender, RoutedEventArgs e)
    {
        var top = TopLevel.GetTopLevel(this);
        if (top is null) return;
        var launcher = top.Launcher;
        await launcher.LaunchUriAsync(new Uri(AppSettings.TitleBarGithubUrl));
    }
}
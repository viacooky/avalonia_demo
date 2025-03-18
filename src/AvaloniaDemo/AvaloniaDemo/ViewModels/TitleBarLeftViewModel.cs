using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace AvaloniaDemo.ViewModels;

public class TitleBarLeftViewModel : ViewModelBase
{
    public string Title => AppSettings.AppName;

    public string Version => AppSettings.AppVersion;

    public Bitmap Icon => new(AssetLoader.Open(new Uri($"avares://AvaloniaDemo/Assets/{AppSettings.IconName}")));
}
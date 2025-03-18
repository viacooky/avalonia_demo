using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaDemo.ViewModels;

public partial class TitleBarLeftViewModel : ViewModelBase
{
    public string Title => AppSettings.AppName;
    
    public string Version => AppSettings.AppVersion;

    public Bitmap Icon => new(AssetLoader.Open(new Uri($"avares://AvaloniaDemo/Assets/{AppSettings.IconPath}")));
}
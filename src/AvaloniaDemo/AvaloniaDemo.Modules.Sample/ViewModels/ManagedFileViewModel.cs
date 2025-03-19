using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Platform.Storage;
using AvaloniaDemo.Shared.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaDemo.Modules.Sample.ViewModels;

public partial class ManagedFileViewModel : ViewModelBase
{
    [ObservableProperty] private string _fileName;
    [ObservableProperty] private string _folder;


    [RelayCommand]
    private async void OpenFolder()
    {
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var rs = await desktop.MainWindow.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions()
            {
                Title = "Select Folder",
                AllowMultiple = true,
            });
            if (rs.Count > 0)
            {
                Folder = rs[0].Path.LocalPath;
            }
        }
    }

    [RelayCommand]
    private async void OpenFile()
    {
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var files = await desktop.MainWindow.StorageProvider.OpenFilePickerAsync(
                new FilePickerOpenOptions
                {
                    Title = "Open Text File",
                    AllowMultiple = false
                });
            if (files.Count > 0)
            {
                FileName = files[0].Name;
            }
        }
    }
}
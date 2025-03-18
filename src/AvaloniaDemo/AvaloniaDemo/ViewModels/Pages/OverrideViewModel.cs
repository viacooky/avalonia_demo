using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaDemo.ViewModels.Pages;

public partial class OverrideViewModel : ViewModelBase
{
    [ObservableProperty] private string _text = string.Empty;
}
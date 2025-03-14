using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaDemo.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _greeting = "Welcome to MainView!";
}
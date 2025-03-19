using AvaloniaDemo.Shared.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaDemo.Modules.Sample.ViewModels
{
    public partial class OverrideViewModel : ViewModelBase
    {
        [ObservableProperty] private string _tt = "这里是Override页面";
    }
}
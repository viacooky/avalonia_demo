using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaDemo.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using Ursa.Controls;

namespace AvaloniaDemo.Views;

public partial class WelcomeWindow : SplashWindow
{
    public WelcomeWindow()
    {
        InitializeComponent();
    }

    protected override async Task<Window?> CreateNextWindow()
    {
        // return DialogResult is true ? new MainWindow(){DataContext = new MainViewModel()} : null;
        if (DialogResult is true)
        {
            return new MainWindow() { DataContext = new MainViewModel() };
        }
        else
        {
            return null;
        }
    }
}
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
    private MainWindow _mainWindow;
    public WelcomeWindow(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
    }

    protected override async Task<Window?> CreateNextWindow()
    {
        if (DialogResult is true)
        {
            return _mainWindow;
        }
        else
        {
            return null;
        }
    }
}
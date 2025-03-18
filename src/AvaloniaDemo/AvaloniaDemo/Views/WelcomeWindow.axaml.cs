using System.Threading.Tasks;
using Avalonia.Controls;
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

    protected override Task<Window?> CreateNextWindow()
    {
        return DialogResult is true
            ? Task.FromResult<Window?>(_mainWindow)
            : Task.FromResult<Window?>(null);
    }
}
using Avalonia.Controls;
using AvaloniaDemo.ViewModels;

namespace AvaloniaDemo.Views;

public partial class TitleBarLeftView : UserControl
{
    public TitleBarLeftView()
    {
        InitializeComponent();
        DataContext = new TitleBarLeftViewModel();
    }
}
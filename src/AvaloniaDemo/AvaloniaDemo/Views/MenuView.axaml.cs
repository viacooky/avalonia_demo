using Avalonia.Controls;
using AvaloniaDemo.ViewModels;

namespace AvaloniaDemo.Views;

public partial class MenuView : UserControl
{
    public MenuView()
    {
        InitializeComponent();
        DataContext = new MenuViewModel();
    }
}
using Avalonia.Controls;
using AvaloniaDemo.ViewModels;

namespace AvaloniaDemo.Views;

public partial class ContentView : UserControl
{
    public ContentView()
    {
        InitializeComponent();
        DataContext = new ContentViewModel();
    }
}
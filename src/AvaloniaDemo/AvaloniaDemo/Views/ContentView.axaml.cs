using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
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
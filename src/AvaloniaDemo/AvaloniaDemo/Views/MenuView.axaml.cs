using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaDemo.Services;
using AvaloniaDemo.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace AvaloniaDemo.Views;

public partial class MenuView : UserControl
{
    public MenuView()
    {
        InitializeComponent();
        DataContext = new MenuViewModel();
    }
}
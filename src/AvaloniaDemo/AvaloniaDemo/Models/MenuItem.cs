using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using AvaloniaDemo.Messages;
using AvaloniaDemo.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace AvaloniaDemo.Models;

public class MenuItem
{
    public string Key { get; set; } = String.Empty;
    public string Name { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = "SemiIconArchive";
    public ICommand ActivateCommand { get; }
    public ObservableCollection<MenuItem> Children { get; set; } = new();

    public string ViewModelType { get; set; } = string.Empty;

    public MenuItem()
    {
        ActivateCommand = new RelayCommand(OnActivate);
    }

    private void OnActivate()
    {
        if (Key == null) return;
        WeakReferenceMessenger.Default.Send(new MenuActivateMessage(this));
    }
}
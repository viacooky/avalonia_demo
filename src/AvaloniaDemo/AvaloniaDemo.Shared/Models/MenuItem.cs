using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using AvaloniaDemo.Shared.Messages;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace AvaloniaDemo.Shared.Models;

public class MenuItem
{
    public MenuItem()
    {
        ActivateCommand = new RelayCommand(OnActivate);
    }

    public string Key { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = "SemiIconArchive";
    public ICommand ActivateCommand { get; }
    public ObservableCollection<MenuItem> Children { get; set; } = new();

    public Type ViewModelType { get; set; } 
    public Type ViewType { get; set; } 

    private void OnActivate()
    {
        if (string.IsNullOrEmpty(Key)) return;
        WeakReferenceMessenger.Default.Send(new MenuActivateMessage(this));
    }
}
using System.Collections.ObjectModel;
using System.Windows.Input;
using AvaloniaDemo.Messages;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace AvaloniaDemo.Models;

public class MenuItem
{
    public string? Key { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; } = "SemiIconArchive";
    public string? ExtraLabel { get; set; }
    public ICommand ActivateCommand { get; }
    public ObservableCollection<MenuItem> Children { get; set; } = new();

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
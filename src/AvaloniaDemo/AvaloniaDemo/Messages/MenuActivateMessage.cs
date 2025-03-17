using AvaloniaDemo.Models;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AvaloniaDemo.Messages;

public class MenuActivateMessage : ValueChangedMessage<MenuItem>
{
    public MenuItem? CurrentMenuItem { get; private set; }

    public MenuActivateMessage(MenuItem menuItem) : base(menuItem)
    {
        CurrentMenuItem = menuItem;
    }
}
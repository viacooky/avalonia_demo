using AvaloniaDemo.Models;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AvaloniaDemo.Messages;

public class MenuActivateMessage : ValueChangedMessage<MenuItem>
{
    public MenuItem? MenuItem { get; private set; }

    public MenuActivateMessage(MenuItem menuItem) : base(menuItem)
    {
        MenuItem = menuItem;
    }
}
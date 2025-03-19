using AvaloniaDemo.Shared.Models;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AvaloniaDemo.Shared.Messages;

public class MenuActivateMessage : ValueChangedMessage<MenuItem>
{
    public MenuActivateMessage(MenuItem menuItem) : base(menuItem)
    {
        MenuItem = menuItem;
    }

    public MenuItem? MenuItem { get; private set; }
}
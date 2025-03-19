using System.Collections.ObjectModel;
using AvaloniaDemo.Shared.Models;

namespace AvaloniaDemo.Shared.Services;

public class MenuService
{
    public ObservableCollection<MenuItem> MenuItems { get; } = [];

    public MenuService AddMenu(MenuItem menuItem)
    {
        MenuItems.Add(menuItem);
        return this;
    }
}
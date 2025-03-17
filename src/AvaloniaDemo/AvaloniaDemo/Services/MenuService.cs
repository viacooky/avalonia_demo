using System.Collections.ObjectModel;
using AvaloniaDemo.Models;

namespace AvaloniaDemo.Services;

public class MenuService
{
    public ObservableCollection<MenuItem> MenuItems { get; } = [];

    public void AddMenu(MenuItem menuItem)
    {
        MenuItems.Add(menuItem);
    }
}
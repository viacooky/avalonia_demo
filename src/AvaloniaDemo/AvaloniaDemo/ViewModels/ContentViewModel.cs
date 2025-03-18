using System;
using AvaloniaDemo.Messages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace AvaloniaDemo.ViewModels;

public partial class ContentViewModel : ViewModelBase
{
    [ObservableProperty] private object? _content;

    public ContentViewModel()
    {
        WeakReferenceMessenger.Default.Register<ContentViewModel, MenuActivateMessage>(this, OnNavigation);
    }

    private void OnNavigation(ContentViewModel recipient, MenuActivateMessage message)
    {
        var typeName = message.MenuItem?.ViewModelType;
        if (string.IsNullOrEmpty(typeName))
        {
            Content = null;
            return;
        }

        try
        {
            var type = Type.GetType(typeName);
            Content = Ioc.Default.GetService(type);
        }
        catch (Exception e)
        {
            Content = null;
            return;
        }
    }
}
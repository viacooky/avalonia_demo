using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Ursa.Controls;

namespace AvaloniaDemo.Views;

public partial class MainWindow : UrsaWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    protected override void OnClosing(WindowClosingEventArgs e)
    {
        var isTray = true; // todo：这里从配置取
        if (isTray)
        {
            e.Cancel = true;
            var tray = TrayIcon.GetIcons(Application.Current!)?.FirstOrDefault();
            if(tray == null) return;
            tray.IsVisible = true;
            Hide(); // 隐藏主窗体
            return;
        }
        // todo: 这里要处理托盘图标
        base.OnClosing(e);
    }
}
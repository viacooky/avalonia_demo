namespace AvaloniaDemo;

public static class AppSettings
{
    #region App设置

    public static string AppName => "AvaloniaDemo";
    public static string AppVersion => "1.0.0.0";

    /// <summary>
    /// 主窗体左上角 icon
    /// Assets目录下的文件名
    /// </summary>
    public static string IconName => "logo.ico";

    #endregion

    #region 主窗体的 Titlebar

    // TitleBar 右侧的github图标
    public static string TitleBarGithubUrl => "https://github.com/neuz";

    #endregion

    #region 启动前的 欢迎窗体

    /// <summary>
    /// 是否启用
    /// </summary>
    public static bool WelcomeWindowEnable => true;

    public static string WelcomeWindowTitle => "Title";
    public static string WelcomeWindowSubTitle => "SubTitle";
    public static string WelcomeWindowLoadingStr => "Loading...";

    /// <summary>
    /// loading加载速度 一般设置 3
    /// </summary>
    public static int WelcomeWindowLoadingSpeed => 10;

    #endregion
}
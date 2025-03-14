namespace AvaloniaDemo;

public static class AppSettings
{
    public static string AppName => "AvaloniaDemo";
    public static string AppVersion => "1.0.0.0";
    
    // TitleBar
    public static string TitleBarGithubUrl => "https://github.com/neuz";
    
    
    // 启动前使用 Welcome窗体
    public static bool WelcomeWindowEnable => true;
    public static string WelcomeWindowTitle => "Title";
    public static string WelcomeWindowSubTitle => "SubTitle";
    /// <summary>
    /// loading加载速度 默认3x
    /// </summary>
    public static int WelcomeWindowLoadingSpeed => 5;
}
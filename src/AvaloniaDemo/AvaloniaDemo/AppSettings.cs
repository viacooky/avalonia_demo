namespace AvaloniaDemo;

public static class AppSettings
{
    public static string AppName => "AvaloniaDemo";
    public static string AppVersion => "1.0.0.0";

    /// <summary>
    /// 在Assets目录下
    /// </summary>
    public static string IconPath => "logo.ico";
    
    // TitleBar Right
    public static string TitleBarGithubUrl => "https://github.com/neuz";
    
    
    // 启动前使用 Welcome窗体
    public static bool WelcomeWindowEnable => true;
    public static string WelcomeWindowTitle => "Title";
    public static string WelcomeWindowSubTitle => "SubTitle";
    /// <summary>
    /// loading加载速度 默认3x
    /// </summary>
    public static int WelcomeWindowLoadingSpeed => 10;
}
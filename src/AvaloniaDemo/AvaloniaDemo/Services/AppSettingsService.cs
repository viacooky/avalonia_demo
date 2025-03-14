namespace AvaloniaDemo.Services;

/// <summary>
/// App 全局设置
/// </summary>
public class AppSettingsService
{
    public string AppName => "AvaloniaDemo";
    public string AppVersion => "1.0.0.0";
    
    // TitleBar
    public string TitleBarGithubUrl => "https://github.com/neuz";
    public string TitleBarTitle => AppName;
    public string TitleBarIconPath => "../Assets/logo.ico";
    
    
    // 启动前使用 Welcome窗体
    public bool WelcomeWindowEnable => true;
    public string WelcomeWindowTitle => "Title";
    public string WelcomeWindowSubTitle => "SubTitle";
    /// <summary>
    /// loading加载速度 默认3x
    /// </summary>
    public int WelcomeWindowLoadingSpeed => 5;
}
namespace Notes;

public partial class MainPage : ContentPage
{
    public const double MyFontSize = 28;
    readonly string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public MainPage()
    {
        InitializeComponent();

        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }
    }

    void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
    }

    void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        editor.Text = string.Empty;
    }
}

public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return MainPage.MyFontSize;
    }
}

// How to write OS specific code using C# 
// MyStackLayout.Padding = 
//    DeviceInfo.Platform == DevicePlatform.iOS
//        ? new Thickness(30, 60, 30, 30) // Shift down by 60 points on iOS only
//        : new Thickness(30); // Set the default margin to be 30 poi
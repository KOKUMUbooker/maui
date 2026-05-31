namespace Notes;

public partial class MainPage : ContentPage
{
    readonly string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public MainPage()
    {
        InitializeComponent();
        if (File.Exists(_fileName))
            NotesEditor.Text = File.ReadAllText(_fileName);
    }

    void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, NotesEditor.Text);
    }

    void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        NotesEditor.Text = string.Empty;
    }
}


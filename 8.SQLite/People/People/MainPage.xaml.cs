using People.Models;

namespace People;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    // NOTE: must be "async void" and not "async Task" since the Clicked event expects a delegate normally with this signature:
    // void Handler(object sender, EventArgs e)
    public async void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        await App.PersonRepo.AddNewPerson(newPerson.Text);
        statusMessage.Text = App.PersonRepo.StatusMessage;
    }

    // NOTE: must be "async void" and not "async Task" since the Clicked event expects a delegate normally with this signature:
    // void Handler(object sender, EventArgs e)
    public async void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Person> people = await App.PersonRepo.GetAllPeople();
        peopleList.ItemsSource = people;
    }

}


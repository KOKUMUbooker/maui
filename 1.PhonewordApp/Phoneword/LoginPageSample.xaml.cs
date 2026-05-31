using System.Diagnostics;

namespace Phoneword;

public partial class LoginPageSample : ContentPage
{
	public LoginPageSample()
	{
		InitializeComponent();
	}

    void LoginButton_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine("Clicked !");
    }
}
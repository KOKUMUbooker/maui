using System.Diagnostics;

using PassXYZLib;

using PasswordManagementApp.Properties;
using PasswordManagementApp.ViewModels;

namespace PasswordManagementApp.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class SignUpPage : ContentPage
{
    private readonly LoginViewModel _viewModel;

    public SignUpPage(LoginViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }
}
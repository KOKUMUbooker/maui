using KPCLib;
using PasswordManagementApp.ViewModels;

namespace PasswordManagementApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public NewItemPage(NewItemViewModel viewModel)
        {
            InitializeComponent();
            if(viewModel == null ) { throw new ArgumentNullException(nameof(viewModel)); }
            BindingContext = viewModel;
        }
    }
}
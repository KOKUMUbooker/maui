using System.Diagnostics;
using KPCLib;
using PasswordManagementApp.ViewModels;

namespace PasswordManagementApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
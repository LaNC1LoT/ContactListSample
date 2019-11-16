using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactListSample.Models;
using ContactListSample.Services;
using ContactListSample.ViewModels;
using Xamarin.Forms;

namespace ContactListSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //ItemsViewModel viewModel;
        public MainPage(IContactsService contactService)
        {
            BindingContext = new MainViewModel(contactService);
            InitializeComponent();

            //BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Contact item))
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            ItemsListView.SelectedItem = null;
        }
    }
}

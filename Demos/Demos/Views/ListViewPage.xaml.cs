using Demos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        private ObservableCollection<Contact> contacts;

        public ListViewPage()
        {


            InitializeComponent();
            contacts = new ObservableCollection<Contact>
            {
                new Contact{Name = "Edgar",Status = "I'm Single", ImageUrl ="http://lorempixel.com/100/100/people/1"},
                new Contact{Name = "Oscar",Status = "I'm Married", ImageUrl ="http://lorempixel.com/100/100/people/2"},
                new Contact{Name = "Madelin",Status = "I'm Alone", ImageUrl ="http://lorempixel.com/100/100/people/3"}


            };

            listView.ItemsSource = contacts;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // listView.SelectedItem = null;
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");

        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            contacts.Remove(contact);
        }

    }
}
using Demos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.SimpleDetailPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name ="Edgar", Status = "I'm Learning Xamarin Forms", ImageUrl = "http://lorempixel.com/100/100/peope/1"},
                new Contact { Name ="Oscar", Status = "I'm Learning Xamarin Forms", ImageUrl = "http://lorempixel.com/100/100/peope/2"},
                new Contact { Name ="Madelin", Status = "I'm Learning Xamarin Forms", ImageUrl = "http://lorempixel.com/100/100/peope/3"}
            };
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;
        }
    }
}
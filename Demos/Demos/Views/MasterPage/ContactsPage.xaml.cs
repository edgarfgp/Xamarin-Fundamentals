using Demos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.MasterPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : MasterDetailPage
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

        void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage( new ContactDetailPage(contact));
            IsPresented = false;// esta propiedad ahce que desaparezca master y que se quede solo detail en telefonos
        }
    }
}
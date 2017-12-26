using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace Demos.Views.ListViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactMethodPage : ContentPage
    {
        public ContactMethodPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<string>
            {
                "None",
                "Email",
                "SMS"

            };

        }
        public ListView ContactMethods { get =>  listView;}

    }
}
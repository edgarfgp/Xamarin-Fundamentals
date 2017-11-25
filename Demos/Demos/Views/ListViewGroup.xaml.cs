using Demos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ListViewGroup()
        {
            InitializeComponent();
            var names = new List<ContactGroup>
            {
                new ContactGroup("E", "E")
                {
                new Contact{Name = "Edgar",Status = "I'm Single", ImageUrl ="http://lorempixel.com/100/100/people/1"},

                },new ContactGroup("O", "O")
                {
                new Contact{Name = "Oscar",Status = "I'm Married", ImageUrl ="http://lorempixel.com/100/100/people/2"},

                },new ContactGroup("M", "M")
                {
                new Contact{Name = "Madelin",Status = "I'm Alone", ImageUrl ="http://lorempixel.com/100/100/people/3"}

                }
            };

            listView.ItemsSource = names;
        }
    }
}
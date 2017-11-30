using Demos.Views.ListViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TableViewPage : ContentPage
	{
		public TableViewPage ()
		{
			InitializeComponent ();
		}

        async void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new ContactMethodPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
           await Navigation.PushAsync(page);
        }


    }
}
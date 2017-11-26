using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.TabbedNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentPage1 : ContentPage
	{
		public ContentPage1 ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageExcercise());
        }
    }
}
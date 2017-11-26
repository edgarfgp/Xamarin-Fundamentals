using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.FormsSettingPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormsPage : ContentPage
	{
		public FormsPage ()
		{
			InitializeComponent ();
		}

        private void Entry_Completed(object sender, EventArgs e)
        {
            label.Text = "Completed";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            label1.Text = e.NewTextValue;
        }
    }
}
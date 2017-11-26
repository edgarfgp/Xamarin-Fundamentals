using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.ViewComponents
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Components : ContentPage
	{
		public Components ()
		{
			InitializeComponent ();
		}

        //nO HACE FALTA HACERLO PROGRAMATICAMENTE ES MEJOR HACERLO DECLARATIVAMENTE
        //private void Switch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    label.IsVisible = e.Value;
        //}

    }
}
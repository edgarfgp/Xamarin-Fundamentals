using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.SimpleNavigationPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
             await Navigation.PopAsync();
            //Para utilizar una ventana modal lo que debemos hacer es
            //PopModalAsync();
        }

        //Al sobreescribir este método y devolver true desactivamos la funcionalidad de
        // ir hacia atras
        //protected override bool OnBackButtonPressed()
        //{
        //    //return base.OnBackButtonPressed();
        //    //De esta manera desactivamos la navegacion hacia atras
        //    return true;
        //}
    }
}
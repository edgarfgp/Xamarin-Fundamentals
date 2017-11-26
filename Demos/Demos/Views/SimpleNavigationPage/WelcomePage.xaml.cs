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
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IntroductionPage());
            //Para utilizar una ventana modal lo que debemos hacer es
            //PushModalAsync(); de esta manera el usuario no podra salir de esta
            //vista hasta que realice lo que qeurramos
            //Otra cosa a tener en cuenta es que hay qiue sobreescribir en
            //Android el metodo  OnBackButtonPressed() PARA PREVENIR el botton hacia atras
        }
    }
}
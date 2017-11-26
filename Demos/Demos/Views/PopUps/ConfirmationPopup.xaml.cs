using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.PopUps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmationPopup : ContentPage
    {
        public ConfirmationPopup()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Confirmation", "Are you Sure", "Yes", "No");
            if (response)
            {
                await DisplayAlert("Done", "Your response will be saved", "OK");
            }
        }
    }
}
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
    public partial class ActionSheet : ContentPage
    {
        public ActionSheet()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Action", "Cancel", "Delete", "Copy Link", "Message", "Email");
            await DisplayAlert("Resonse", response, "Ok");
        }
    }
}
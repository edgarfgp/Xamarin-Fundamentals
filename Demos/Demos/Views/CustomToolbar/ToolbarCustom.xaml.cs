using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.CustomToolbar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolbarCustom : ContentPage
    {
        public ToolbarCustom()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            //En el mundo real deveriamos poner un mensahje de confirmación
            DisplayAlert("Activated", "ToolbarItemActivated 1", "OK");
        }

        private void ToolbarItem_Activated_1(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItemActivated 2", "OK");
        }
    }
}
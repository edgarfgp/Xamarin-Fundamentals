using Demos.ViewModels;
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
    public partial class BasicsPage : ContentPage
    {
        public BasicsPage()
        {
            InitializeComponent();
            BindingContext = new BasicsViewModel();
            slider.Value = 0.5;

            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello World from C#"
            //};
           
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value is {0:F2}", e.NewValue);
            
        }
    }
}
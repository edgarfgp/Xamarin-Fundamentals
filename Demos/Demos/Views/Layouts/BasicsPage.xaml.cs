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
            // BindingContext = new BasicsViewModel();
            slider.Value = 0.5;

            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello World from C#"
            //};

            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    Padding = new Thickness(20, 20,20,20);
            //}else if(Device.RuntimePlatform == Device.iOS)
            //{
            //    Padding = new Thickness(30, 30, 30, 30);
            //}
            //else
            //{
            //    Padding = new Thickness(50, 50, 50, 50);
            //}


            //switch (Device.RuntimePlatform)
            //{
            //    case Device.Android:
            //        Padding = new Thickness(50, 60, 20, 20);
            //        break;

            //    case Device.iOS:
            //        Padding = new Thickness(30, 30, 30, 30);
            //        break;

            //    case Device.WinPhone:
            //        Padding = new Thickness(50, 50, 50, 50);
            //        break;

            //    default:
            //        Padding = new Thickness(0, 0, 0, 0);
            //        break;
            //}



        }  

        

    }

}

       
    
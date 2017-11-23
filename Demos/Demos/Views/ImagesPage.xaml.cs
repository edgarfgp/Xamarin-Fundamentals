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
    public partial class ImagesPage : ContentPage
    {
        public ImagesPage()
        {
            InitializeComponent();
            // var imageSource = new UriImageSource
            // {
            //     Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/")
            // };
            // imageSource.CachingEnabled = false;
            //// imageSource.CacheValidity = TimeSpan.FromHours(1);
            // image.Source = imageSource;

            // image.Aspect = Aspect.AspectFill;
            image.Source = ImageSource.FromResource("Demos.images.dev.jpg");
           
        }
    }
}
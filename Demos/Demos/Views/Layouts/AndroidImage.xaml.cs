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
    public partial class AndroidImage : ContentPage
    {
        public AndroidImage()
        {
            InitializeComponent();

            //btn.Image = (FileImageSource) ImageSource.FromResource("clock.png");

            //btn.Image = (FileImageSource)ImageSource.FromResource(Device.OnPlatform(
            //    iOS: "clock.png",
            //    Android: "clock.png",
            //    WinPhone: "clock.png"
            //    ));

        }
    }
}
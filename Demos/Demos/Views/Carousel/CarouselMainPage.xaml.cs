using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselMainPage : CarouselPage
    {
        public CarouselMainPage()
        {
            InitializeComponent();
            //Al carouselPage solo le podemos añadir ContentPage
            //Por lo tanto no podemos añadir NavigationPage
            //Al igual que en los tabpage podemos refereciar contenpage externos mediante un espacio de nombres
        }
    }
}
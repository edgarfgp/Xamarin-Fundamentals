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
	public partial class ExcersiceStackPage : ContentPage
	{
		public ExcersiceStackPage ()
		{
			InitializeComponent ();

            //var layout = new StackLayout
            //{
            //    Spacing = 40,
            //    Padding = new Thickness(0, 20, 0, 0),
            //    Orientation = StackOrientation.Horizontal,
            //    HorizontalOptions = LayoutOptions.Center
                
            //};

            //var label1 = new Label
            //{
            //    Text = "Label 1",
            //    FontSize = 14
                
            //};
            //layout.Children.Add(label1);

            //Content = layout;
		}
	}
}
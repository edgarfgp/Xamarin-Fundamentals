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
	public partial class GridPage : ContentPage
	{
		public GridPage ()
		{
			InitializeComponent ();

            //var grid = new Grid
            //{
            //    RowSpacing = 0,
            //    ColumnSpacing = 0,
            //    BackgroundColor = Color.Yellow
            //};

            //var label1 = new Label
            //{
            //    Text = "Label 1",
            //    VerticalTextAlignment = TextAlignment.Center,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    BackgroundColor  = Color.Tomato
            //};
            //var label2 = new Label
            //{
            //    Text = "Label 2",
            //    VerticalTextAlignment = TextAlignment.Center,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    BackgroundColor = Color.Orange

            //};
            //var label3 = new Label
            //{
            //    Text = "Label 3",
            //    VerticalTextAlignment = TextAlignment.Center,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    BackgroundColor = Color.Peru
            //};
            //var label4 = new Label
            //{
            //    Text = "Label 4",
            //    VerticalTextAlignment = TextAlignment.Center,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    BackgroundColor = Color.Blue
            //};

            //grid.Children.Add(label1, 0,0);
            //grid.Children.Add(label2, 0, 1);
            //grid.Children.Add(label3, 1, 0);
            //grid.Children.Add(label4, 1, 1);
            


            //Content = grid;
		}
	}
}
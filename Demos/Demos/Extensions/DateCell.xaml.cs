using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Extensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateCell : ViewCell
	{

        //This is the way to bindable properties
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string) , typeof(DateCell));
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public DateCell ()
		{
			InitializeComponent ();
            BindingContext = this;
		}
	}
}
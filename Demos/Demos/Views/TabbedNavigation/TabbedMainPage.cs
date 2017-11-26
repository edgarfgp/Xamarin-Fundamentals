using Demos.Views.MasterPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.TabbedNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedMainPage : TabbedPage
	{
		public TabbedMainPage ()
		{
			InitializeComponent ();
            //En el mundo real las tbsse añaden en xaml
            //this.Children.Add(new ContentPage());
            //this.Children.Add(new NavigationPage( new ContentPage()));
            //this.Children.Add(new ContactsPage());

		}
	}
}
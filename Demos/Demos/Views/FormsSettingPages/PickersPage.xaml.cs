using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views.FormsSettingPages
{

    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickersPage : ContentPage
	{
        private IList<ContactMethod> _contactMethods;

		public PickersPage ()
		{
			InitializeComponent ();
            _contactMethods = GetContactMethod();
            foreach (var item in _contactMethods)
            {
                contactMethods.Items.Add(item.Name);
            }
		}

        private IList<ContactMethod> GetContactMethod()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id= 1, Name="SMS"},
                new ContactMethod { Id= 2, Name="EMAIL"}
            };
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
           var name =  contactMethods.Items[contactMethods.SelectedIndex];
           var contactMethod = _contactMethods.Single(cm => cm.Name == name);

            DisplayAlert("Selection", name, "Ok");
        }
    }
}
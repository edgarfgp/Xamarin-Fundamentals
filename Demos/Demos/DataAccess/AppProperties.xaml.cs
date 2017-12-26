using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppProperties : ContentPage
    {
        public AppProperties()
        {
            InitializeComponent();
            BindingContext = Application.Current;
            //var app = Application.Current as App;

            //title.Text = app.Title;
            //notificationsEnable.On = app.NotificationsEnable;
        }

        //private void OnChanged(object sender, EventArgs e)
        //{
        //    var app = Application.Current as App;
        //    app.Title = title.Text;
        //    app.NotificationsEnable = notificationsEnable.On;

        //    //You can call this method if you want
        //    //save the info as soon as posible
        //    // Application.Current.SavePropertiesAsync();
        //}
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }

}
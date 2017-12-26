using Demos.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Demos
{
    public partial class App : Application
    {
        private const string TitleKey = "Name";
        private const string NotificationsEnableKey = "NotificationsEnable";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                //De esta manera podemos personalizar nuestra navegación
                //BackgroundColor = Color.Gray,
                //BarTextColor = Color.Peru
            };
        }

        public bool NotificationsEnable
        {
            get => Properties.ContainsKey(NotificationsEnableKey) ? (bool) Properties[NotificationsEnableKey] : false;
            set => Properties[NotificationsEnableKey] = value;
        }
        public string Title
        {
            get => Properties.ContainsKey(TitleKey) ? Properties[TitleKey].ToString() : "";
            set => Properties[TitleKey] = value;
        }

        protected override void OnStart()
        {

            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

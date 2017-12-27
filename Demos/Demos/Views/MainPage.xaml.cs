using Demos.DataAccess;
using Demos.FileSystem;
using Demos.NetflixApp;
using Demos.Persistence;
using Demos.RestfulServices;
using Demos.ViewModels;
using Demos.Views;
using Demos.Views.Carousel;
using Demos.Views.CustomToolbar;
using Demos.Views.FormsSettingPages;
using Demos.Views.InstagramApp;
using Demos.Views.Layouts;
using Demos.Views.PopUps;
using Demos.Views.SimpleDetailPage;
using Demos.Views.SimpleNavigationPage;
using Demos.Views.TabbedNavigation;
using Demos.Views.ViewComponents;
using System;
using Xamarin.Forms;

namespace Demos
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasicsPage());
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuotesPage());
        }

        async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExcersiceStackPage());
        }

        async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Excersicestack());
        }

        async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }

        async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridExercise());
        }

        async void Button_Clicked_6(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new AbsolutePage());
        }

        async void Button_Clicked_7(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new AbsolueExercise());
        }

        async void Button_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativePage());
        }

        async void Button_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeExcersice());
        }

        async void Button_Clicked_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImagesPage());
        }

        async void Button_Clicked_11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image2());
        }

        async void Button_Clicked_12(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AndroidImage());
        }

        async void Button_Clicked_13(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RoundedImage());
        }

        async void Button_Clicked_14(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageExcercise());
        }

        async void Button_Clicked_15(object sender, EventArgs e) => await Navigation.PushAsync(new ListViewPage());

        async void Button_Clicked_16(object sender, EventArgs e) => await Navigation.PushAsync(new ListViewCustom());

        async void Button_Clicked_17(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewGroup());
        }

        async void Button_Clicked_18(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomePage());
        }

        async void Button_Clicked_19(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactsPage());
        }

        async void Button_Clicked_20(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MasterPage.ContactsPage());
        }

        async void Button_Clicked_21(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedMainPage());
        }

        async void Button_Clicked_22(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarouselMainPage());
        }

        async void Button_Clicked_23(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfirmationPopup());
        }

        async void Button_Clicked_24(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionSheet());
        }

        async void Button_Clicked_25(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToolbarCustom());
        }

        async void Button_Clicked_26(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainAppPage());
        }

        async void Button_Clicked_27(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Components());
        }

        async void Button_Clicked_28(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormsPage());
        }

        async void Button_Clicked_29(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditorsPage());
        }

        async void Button_Clicked_30(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickersPage());
        }

        async void Button_Clicked_31(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DateTimePicker());
        }

        async void Button_Clicked_32(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TableViewPage());
        }

        async void Button_Clicked_33(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactsApp.ContactsPage());
        }

        async void Button_Clicked_34(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppProperties());
        }

        async void Button_Clicked_35(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FileSystemPage());
        }

        async void Button_Clicked_36(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PersistencePage());
        }

        async  void Button_Clicked_37(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RestfullPage());
        }

        async void Button_Clicked_38(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MoviesPage());
        }
    }

}

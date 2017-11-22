﻿using Demos.ViewModels;
using Demos.Views;
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BasicsPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuotesPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExcersiceStackPage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Excersicestack());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridExercise());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {

            Navigation.PushAsync(new AbsolutePage());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {

            Navigation.PushAsync(new AbsolueExercise());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativePage());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativeExcersice());
        }
    }

}

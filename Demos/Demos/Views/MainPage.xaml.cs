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
    }
}

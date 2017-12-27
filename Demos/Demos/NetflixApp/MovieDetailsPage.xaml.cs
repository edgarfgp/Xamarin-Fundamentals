using Demos.Models;
using Demos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.NetflixApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailsPage : ContentPage
    {
        private MovieService _movieService = new MovieService();
        private Movie _movie;

        public MovieDetailsPage(Movie movie)
        {
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            _movie = movie;

            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            BindingContext = await _movieService.GetMovie(_movie.Title);

            base.OnAppearing();
        }
    }
}
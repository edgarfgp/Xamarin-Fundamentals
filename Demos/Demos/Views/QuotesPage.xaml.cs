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
    public partial class QuotesPage : ContentPage
    {

        private int index = 0;
        private string[] quotes = new string[]
        {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };
        public QuotesPage()
        {
            InitializeComponent();
            quote.Text = quotes[index];


        }

        private void Handle_Clicked(object sender, EventArgs e)

        {
            index++;
            if (index >= quotes.Length)
                index = 0;

            quote.Text = quotes[index];
        }
    }
}
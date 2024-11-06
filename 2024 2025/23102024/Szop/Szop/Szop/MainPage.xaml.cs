using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szop.Pages;
using Xamarin.Forms;

namespace Szop
{
    public partial class MainPage : ContentPage
    {
        double price = 0,
            amount = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e) =>
            await Navigation.PushAsync(new ResultPage(price * amount));

        private void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(AmountEntry.Text) || string.IsNullOrEmpty(PriceEntry.Text))
                return;

            if (
                !double.TryParse(AmountEntry.Text.Replace(",", "."), out amount)
                || !double.TryParse(PriceEntry.Text.Replace(",", "."), out price)
            )
            {
                ResultBtn.IsEnabled = false;
                return;
            }
            if (amount <= 0 || price <= 0)
            {
                ResultBtn.IsEnabled = false;
                return;
            }
            ResultBtn.IsEnabled = true;
        }
    }
}

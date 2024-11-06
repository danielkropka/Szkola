using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AddressButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddressPage(ConvertAddressFromName(NameEntry.Text)));
        }

        private async void HobbyButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HobbyPage(ConvertHobbyFromName(NameEntry.Text)));
        }

        private string ConvertAddressFromName(string name)
        {
            switch (name)
            {
                case "Maciek":
                    return "Aleksandrów";
                case "Ola":
                    return "Łódź";
                default:
                    return string.Empty;
            }
        }

        private string ConvertHobbyFromName(string hobby)
        {
            switch (hobby)
            {
                case "Maciek":
                    return "Sport";
                case "Ola":
                    return "Film";
                default:
                    return string.Empty;
            }
        }
    }
}

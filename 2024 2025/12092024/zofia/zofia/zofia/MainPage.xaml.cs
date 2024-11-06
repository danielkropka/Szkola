using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zofia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            EntryName.Focus();
        }

        private void HandleButtonClick(object sender, EventArgs e)
        {
            string entryValue = EntryName.Text;
            if (string.IsNullOrWhiteSpace(entryValue))
            {
                DisplayAlert("Błąd danych!", "Wprowadź poprawne dane do pola Imię", "Zamknij");
                return;
            }
            DisplayAlert("Alert", $"Cześć, {entryValue}!", "OK");
        }
    }
}

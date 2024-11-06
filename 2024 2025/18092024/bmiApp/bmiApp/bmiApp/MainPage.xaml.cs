using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bmiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (HeightEntry == null || WeightEntry == null)
                return;
            if (
                !double.TryParse(HeightEntry.Text, out double height)
                || !double.TryParse(WeightEntry.Text, out double weight)
            )
            {
                DisplayAlert("Wystąpił błąd!", "Podaj właściwe wartości.", "Zamnkij");
                return;
            }

            ResultBMI.Text = Math.Round(weight / (height * height), 2).ToString();
        }
    }
}

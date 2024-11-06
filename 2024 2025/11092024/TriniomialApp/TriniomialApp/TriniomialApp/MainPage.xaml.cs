using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TriniomialApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClearLables()
        {
            DeltaResult.Text = string.Empty;
            ArmsResultLabel.Text = string.Empty;
            VertexResultLabel.Text = string.Empty;
            X1ResultLabel.Text = string.Empty;
            X2ResultLabel.Text = string.Empty;
            SqrtResult.Text = string.Empty;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            double a,
                b,
                c;
            if (
                !double.TryParse(AEntry.Text, out a)
                || !double.TryParse(BEntry.Text, out b)
                || !double.TryParse(CEntry.Text, out c)
            )
            {
                ClearLables();
                return;
            }
            if (a == 0)
            {
                DisplayAlert("Podano błędne dane!", "Pole `A`, nie może być zerem.", "Zamknij");
                AEntry.Focus();
            }
            double delta = b * b - 4 * a * c;
            DeltaResult.Text = delta.ToString();
            SqrtResult.Text = (
                delta > 0 ? 2
                : delta == 0 ? 1
                : 0
            ).ToString();
        }
    }
}

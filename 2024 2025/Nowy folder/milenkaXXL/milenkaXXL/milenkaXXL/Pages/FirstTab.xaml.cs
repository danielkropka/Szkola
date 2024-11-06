using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace milenkaXXL.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstTab : ContentPage
    {
        public FirstTab()
        {
            InitializeComponent();
        }

        private void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(FirstNumber.Text, out double firstNumber))
            {
                MessagingCenter.Send<string, double>("FirstNSender", "VChanged", firstNumber);

                if (double.TryParse(SecondNumber.Text, out double secondNumber))
                {
                    if (secondNumber == 0)
                    {
                        DisplayAlert("Wystąpił błąd!", "Pole b nie może być równe 0", "Zamknij");

                        MessagingCenter.Send<string, double>("NoResult", "VChanged", double.NaN);

                        return;
                    }
                    MessagingCenter.Send<string, double>("SecondNSender", "VChanged", secondNumber);

                    return;
                }
            }

            MessagingCenter.Send<string, double>("NoResult", "VChanged", double.NaN);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriniomialApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class abcTab : ContentPage
    {
        public abcTab()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = sender as Entry;
            if (double.TryParse(entry.Text, out double n))
                if (entry == AEntry)
                {
                    if (n == 0)
                    {
                        DisplayAlert("Wystąpił błąd", "`a`, nie może być równe 0", "Zamknij");
                        return;
                    }
                    MessagingCenter.Send<string, double>("AEntry", "VChanged", n);
                }
                else if (entry == BEntry)
                    MessagingCenter.Send<string, double>("BEntry", "VChanged", n);
                else
                    MessagingCenter.Send<string, double>("CEntry", "VChanged", n);
        }
    }
}

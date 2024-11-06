using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class A : ContentPage
    {
        public A()
        {
            InitializeComponent();
        }

        private void AEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            // MessagingCenter.Send<object, double>(this, "AEntryChanged", double.Parse(AEntry.Text));
            MessagingCenter.Send<string, string>("ASender", "VChanged", AEntry.Text);
        }
    }
}

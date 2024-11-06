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
    public partial class B : ContentPage
    {
        public B()
        {
            InitializeComponent();
        }

        private void BEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //MessagingCenter.Send<object, double>(this, "BEntryChanged", double.Parse(BEntry.Text));
            MessagingCenter.Send<string, string>("BSender", "VChanged", BEntry.Text);
        }
    }
}

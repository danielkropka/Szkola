using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstTabbedApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class first : ContentPage
    {
        public first()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (AEntry == null || BEntry == null)
                return;
            if (
                double.TryParse(AEntry.Text, out double AValue)
                && double.TryParse(BEntry.Text, out double BValue)
            )
                ResultEntry.Text = (AValue + BValue).ToString();
            second second = new second();
        }
    }
}

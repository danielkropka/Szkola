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
    public partial class ApexTab : ContentPage
    {
        public ApexTab()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<string, string>(
                this,
                "ApexChanged",
                (sender, args) =>
                {
                    if (sender == "ApexEntry")
                        ApexEntry.Text = args;
                }
            );
        }
    }
}

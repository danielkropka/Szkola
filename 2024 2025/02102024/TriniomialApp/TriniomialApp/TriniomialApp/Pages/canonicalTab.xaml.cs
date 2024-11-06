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
    public partial class canonicalTab : ContentPage
    {
        public canonicalTab()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<string, string>(
                this,
                "CanonicalChanged",
                (sender, args) =>
                {
                    if (sender == "CanonicalEntry")
                        CanonicalEntry.Text = args;
                }
            );
        }
    }
}

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
    public partial class productTab : ContentPage
    {
        public productTab()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<string, string>(
                this,
                "ProductChanged",
                (sender, args) =>
                {
                    if (sender == "ProductEntry")
                        ProductEntry.Text = args;
                }
            );
        }
    }
}

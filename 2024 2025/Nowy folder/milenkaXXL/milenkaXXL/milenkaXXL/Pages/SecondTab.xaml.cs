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
    public partial class SecondTab : ContentPage
    {
        private double a = 0,
            b = 0;

        public SecondTab()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<string, double>(
                this,
                "VChanged",
                (sender, args) =>
                {
                    if (sender == "NoResult")
                    {
                        Result.Text = string.Empty;
                        return;
                    }
                    else if (sender == "FirstNSender")
                        a = args;
                    else
                        b = args;

                    Result.Text = $"{a / b}";
                }
            );
        }
    }
}

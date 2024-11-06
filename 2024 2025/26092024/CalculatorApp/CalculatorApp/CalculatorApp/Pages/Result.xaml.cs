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
    public partial class Result : ContentPage
    {
        double a = 0,
            b = 0;

        public Result()
        {
            InitializeComponent();
            /*MessagingCenter.Subscribe<object, double>(
                this,
                "AEntryChanged",
                (Asender, Aargs) =>
                {
                    MessagingCenter.Subscribe<object, double>(
                        this,
                        "BEntryChanged",
                        (Bsender, Bargs) =>
                        {
                            ResultLabel.Text = (Aargs + Bargs).ToString();
                        }
                    );
                }
            );*/
            MessagingCenter.Subscribe<string, string>(
                this,
                "VChanged",
                (sender, args) =>
                {
                    if (sender == "ASender")
                        a = double.Parse(args);
                    else
                        b = double.Parse(args);
                    ResultLabel.Text = (a + b).ToString();
                }
            );
        }
    }
}

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
    public partial class deltaAndSolutionsTab : ContentPage
    {
        double a = 0,
            b = 0,
            c = 0;

        public double Delta => (b * b) - 4 * a * c;
        public (double, double) Solutions
        {
            get
            {
                if (Delta == 0)
                    return (-b / 2 * a, 0);
                else if (Delta > 0)
                    return ((-b + Math.Sqrt(Delta)) / 2 * a, (-b - Math.Sqrt(Delta)) / 2 * a);
                return (0, 0);
            }
        }

        public double P => -b / 2 * a;
        public double Q => -Delta / 4 * a;

        public deltaAndSolutionsTab()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<string, double>(
                this,
                "VChanged",
                (sender, args) =>
                {
                    if (sender == "AEntry")
                        a = args;
                    else if (sender == "BEntry")
                        b = args;
                    else
                        c = args;

                    DeltaEntry.Text = Delta.ToString();

                    var (x1, x2) = Solutions;
                    if (Delta == 0)
                        X1Entry.Text = x1.ToString();
                    else if (Delta > 0)
                    {
                        X1Entry.Text = x1.ToString();
                        X2Entry.Text = x2.ToString();
                    }
                    else
                    {
                        X1Entry.Text = "-";
                        X2Entry.Text = "-";
                    }

                    MessagingCenter.Send<string, string>("ApexEntry", "ApexChanged", $"({P}, {Q})");
                    MessagingCenter.Send<string, string>(
                        "CanonicalEntry",
                        "CanonicalChanged",
                        $"{a}(x - {P})^2 + {Q}"
                    );
                    MessagingCenter.Send<string, string>(
                        "ProductEntry",
                        "ProductChanged",
                        $"{a}(x - {x1})(x - {x2})"
                    );
                }
            );
        }
    }
}

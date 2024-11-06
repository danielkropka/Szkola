using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Copy : ContentPage
    {
        public Copy()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<object, string>(
                this,
                "FirstNameChanged",
                (sender, args) =>
                {
                    CopyLabel.Text = args;
                }
            );
        }
    }
}

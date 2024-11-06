using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HobbyPage : ContentPage
    {
        public HobbyPage(string hobby)
        {
            InitializeComponent();
            HobbyLabel.Text = hobby;
        }
    }
}

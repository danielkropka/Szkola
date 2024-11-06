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
    public partial class Original : ContentPage
    {
        public Original()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessagingCenter.Send<object, string>(this, "FirstNameChanged", OriginalEntry.Text);
        }
    }
}

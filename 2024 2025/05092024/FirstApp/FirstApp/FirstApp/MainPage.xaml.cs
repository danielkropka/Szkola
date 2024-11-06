using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddBtn.IsEnabled = false;
            AEntry.CursorPosition = 0;
        }

        private void Handle_Input(object sender, TextChangedEventArgs e)
        {
            if (!double.TryParse(AEntry.Text, out _) || !double.TryParse(BEntry.Text, out _))
                AddBtn.IsEnabled = false;
            else
                AddBtn.IsEnabled = true;
        }

        private void AddBtn_Clicked(object sender, EventArgs e) =>
            Result.Text = (double.Parse(AEntry.Text) + double.Parse(BEntry.Text)).ToString();
    }
}

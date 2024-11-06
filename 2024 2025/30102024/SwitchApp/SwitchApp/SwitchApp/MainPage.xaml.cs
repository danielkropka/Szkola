using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwitchApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            var contrastSwitch = sender as Switch;
            if (contrastSwitch == null)
                return;
            if (contrastSwitch.IsToggled)
            {
                FrameBox.BackgroundColor = Color.Black;
                LabelText.TextColor = Color.White;
            }
            else
            {
                FrameBox.BackgroundColor = Color.LightGray;
                LabelText.TextColor = Color.Black;
            }
        }
    }
}

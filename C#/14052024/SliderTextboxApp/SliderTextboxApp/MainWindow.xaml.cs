using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SliderTextboxApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandleColorSlider(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (
                TBR == null
                || TBG == null
                || TBB == null
                || SliderColorR == null
                || SliderColorG == null
                || SliderColorB == null
            )
                return;
            TBR.Text = SliderColorR.Value.ToString();
            TBG.Text = SliderColorG.Value.ToString();
            TBB.Text = SliderColorB.Value.ToString();
            RectangleRGB.Fill = new SolidColorBrush(
                Color.FromRgb(
                    (byte)SliderColorR.Value,
                    (byte)SliderColorG.Value,
                    (byte)SliderColorB.Value
                )
            );
        }

        private void HandleTBChange(object sender, TextChangedEventArgs e)
        {
            var changedTB = (TextBox)sender;
            switch (changedTB.Name)
            {
                case "TBR":
                    if (double.TryParse(changedTB.Text, out double r))
                        SliderColorR.Value = r;
                    break;
                case "TBG":
                    if (double.TryParse(changedTB.Text, out double g))
                        SliderColorG.Value = g;
                    break;
                case "TBB":
                    if (double.TryParse(changedTB.Text, out double b))
                        SliderColorB.Value = b;
                    break;
            }
        }
    }
}

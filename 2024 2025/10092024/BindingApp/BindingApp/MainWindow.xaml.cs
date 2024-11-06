using System;
using System.Collections.Generic;
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

namespace BindingApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TB.Text = "1";
            Slider.Value = 1;
            Binding binding = new Binding("Value");
            binding.ElementName = "FifthSlider";
            FifthTB.SetBinding(TextBox.TextProperty, binding);
        }

        private void HandleSliderChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (TB == null || Slider == null)
                return;
            TB.Text = Slider.Value.ToString();
        }
    }
}

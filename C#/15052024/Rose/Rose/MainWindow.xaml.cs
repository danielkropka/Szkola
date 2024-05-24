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

namespace Rose
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MySlider.Value = 1;
            TBValue.Text = "1";
        }

        private void HandleTBInput(object sender, TextChangedEventArgs e)
        {
            if (MySlider == null)
                return;
            if (double.TryParse(TBValue.Text, out double result))
            {
                MySlider.Value = result;
                return;
            }
            MySlider.Value = 1;
        }

        private void HandleSlider(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (TBValue == null)
                return;
            TBValue.Text = MySlider.Value.ToString();
        }
    }
}

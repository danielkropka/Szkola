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

namespace popu
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

        private void Calculate(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(TBa.Text);
            double b = double.Parse(TBb.Text);
            TBResult.Text = $"{a + b}";
        }

        private void TBValidation(object sender, TextChangedEventArgs e)
        {
            if (!double.TryParse(TBa.Text, out _) || !double.TryParse(TBb.Text, out _))
            {
                BResult.IsEnabled = false;
                return;
            }
            if (!BResult.IsEnabled)
                BResult.IsEnabled = true;
        }
    }
}

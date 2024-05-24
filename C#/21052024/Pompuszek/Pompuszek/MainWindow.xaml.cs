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

namespace Pompuszek
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

        private void HandlePlusCalculation(object sender, RoutedEventArgs e) =>
            ResultTB.Text = $"{double.Parse(aTB.Text) + double.Parse(bTB.Text)}";

        private void HandleMinusCalculation(object sender, RoutedEventArgs e) =>
            ResultTB.Text = ResultTB.Text = $"{double.Parse(aTB.Text) - double.Parse(bTB.Text)}";

        private void HandleMultiplyCalculation(object sender, RoutedEventArgs e) =>
            ResultTB.Text = ResultTB.Text = $"{double.Parse(aTB.Text) * double.Parse(bTB.Text)}";

        private void HandleDivisionCalculation(object sender, RoutedEventArgs e)
        {
            double bValue = double.Parse(bTB.Text);
            if (bValue == 0)
            {
                ResultTB.Text = "Debilu nie dziel przez 0";
                return;
            }
            ResultTB.Text = ResultTB.Text = $"{double.Parse(aTB.Text) / bValue}";
        }
    }
}

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

namespace apteka
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

        private void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            var clickedButton = (Button)sender;
            if (clickedButton == null)
                return;
            if (clickedButton.Name == "PlusBtn")
            {
                if (double.TryParse(TBNumber.Text, out double numberTB))
                    ResultTB.Text = $"{double.Parse(ResultTB.Text) + numberTB}";
            }
            else if (clickedButton.Name == "MinusBtn")
            {
                if (double.TryParse(TBNumber.Text, out double numberTB))
                    ResultTB.Text = $"{double.Parse(ResultTB.Text) - numberTB}";
            }
            checkInputs();
        }

        private void HandleInputChange(object sender, TextChangedEventArgs e)
        {
            if (TBNumber == null || ResultTB == null)
                return;
            checkInputs();
        }

        private void checkInputs()
        {
            if (double.TryParse(TBNumber.Text, out double result))
            {
                if (result < 1)
                    return;
                MinusBtn.IsEnabled = true;
                PlusBtn.IsEnabled = true;
                if (double.Parse(ResultTB.Text) - result < 0)
                    MinusBtn.IsEnabled = false;
                else if (!MinusBtn.IsEnabled)
                    MinusBtn.IsEnabled = true;
                if (double.Parse(ResultTB.Text) + result > 100)
                    PlusBtn.IsEnabled = false;
                else if (!PlusBtn.IsEnabled)
                    PlusBtn.IsEnabled = true;
                return;
            }
            MinusBtn.IsEnabled = false;
            PlusBtn.IsEnabled = false;
        }
    }
}

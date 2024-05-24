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

namespace IncrementApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            checkResult();
        }

        private void HandleClickBtn(object sender, RoutedEventArgs e)
        {
            var clickedBtn = (Button)sender;
            if (clickedBtn == null)
                return;

            if (clickedBtn.Name == "PlusBtn")
                ResultTB.Text = $"{int.Parse(ResultTB.Text) + 1}";
            else if (clickedBtn.Name == "MinusBtn")
                ResultTB.Text = $"{int.Parse(ResultTB.Text) - 1}";
            checkResult();
        }

        private void checkResult()
        {
            int result = int.Parse(ResultTB.Text);
            if (result == 0)
                MinusBtn.IsEnabled = false;
            else if (result == 10)
                PlusBtn.IsEnabled = false;
            else
            {
                if (!MinusBtn.IsEnabled)
                    MinusBtn.IsEnabled = true;
                if (!PlusBtn.IsEnabled)
                    PlusBtn.IsEnabled = true;
            }
        }
    }
}

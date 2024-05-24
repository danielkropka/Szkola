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

namespace ButtonMessageApp
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

        private void MessageBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("KK", "Uwaga!", MessageBoxButton.OKCancel, MessageBoxImage.Error);
        }

        private void InfoMsgBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("KK", "Informacja!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

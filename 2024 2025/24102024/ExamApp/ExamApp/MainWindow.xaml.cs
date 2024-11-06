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

namespace ExamApp
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

        private void CheckPrice_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedImage == null)
                return;
            if (PostCardRB.IsChecked == true)
            {
                SelectedImage.Source = new BitmapImage(
                    new Uri("/Images/pocztowka.png", UriKind.Relative)
                );
                PriceLabel.Content = "1 zł";
            }
            else if (LetterRB.IsChecked == true)
            {
                SelectedImage.Source = new BitmapImage(
                    new Uri("/Images/list.png", UriKind.Relative)
                );
                PriceLabel.Content = "1,5 zł";
            }
            else if (PackageRB.IsChecked == true)
            {
                SelectedImage.Source = new BitmapImage(
                    new Uri("/Images/paczka.png", UriKind.Relative)
                );
                PriceLabel.Content = "10 zł";
            }
        }

        private void CheckPostalCode_Click(object sender, RoutedEventArgs e)
        {
            int postalCodeLength = PostalCodeTBox.Text.Length;
            if (postalCodeLength > 5 || postalCodeLength < 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                return;
            }
            if (!int.TryParse(PostalCodeTBox.Text, out _))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
                return;
            }
            MessageBox.Show("Dane przesyłki zostały wprowadzone");
        }
    }
}

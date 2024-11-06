using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SzczekSzczek
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    class MultipleSign : INotifyPropertyChanged
    {
        int quantity;
        string sign = "*";

        public int Quantity
        {
            get => quantity;
            set
            {
                if (
                    !int.TryParse(quantity.ToString(), out quantity)
                    || quantity < 0
                    || quantity == value
                )
                    return;
                quantity = value;
                UpdatedProperties("Quantity");
            }
        }

        public string Sign
        {
            get => sign;
            set
            {
                sign = value;
                UpdatedProperties("Sign");
            }
        }

        public string Output
        {
            get
            {
                string result = string.Empty;
                for (int i = 0; i < Quantity; i++)
                    result += Sign;
                return result;
            }
        }

        public void UpdatedProperties(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Output"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

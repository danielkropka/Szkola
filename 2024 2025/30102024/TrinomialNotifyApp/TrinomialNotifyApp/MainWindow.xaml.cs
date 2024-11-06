using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

namespace TrinomialNotifyApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    public class ElementsConverterClass : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || (value is double v && double.IsNaN(v)))
                return "-";
            return Math.Round((double)value, 2);
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture
        )
        {
            throw new NotImplementedException();
        }
    }

    public class Trinomial : INotifyPropertyChanged
    {
        double a,
            b,
            c;

        public double A
        {
            get => a;
            set
            {
                if (value == 0 || value == a)
                    return;
                a = value;
                UpdateProperties("A");
            }
        }
        public double B
        {
            get => b;
            set
            {
                b = value;
                UpdateProperties("B");
            }
        }
        public double C
        {
            get => c;
            set
            {
                c = value;
                UpdateProperties("C");
            }
        }

        public double Delta
        {
            get => Math.Pow(B, 2) - 4 * A * C;
        }

        public int NumberOfElements
        {
            get =>
                Delta > 0 ? 2
                : Delta == 0 ? 1
                : 0;
        }

        public double? X1
        {
            get
            {
                if (NumberOfElements < 0)
                    return null;
                return (-B - Math.Sqrt(Delta)) / (2 * a);
            }
        }

        public double? X2
        {
            get
            {
                if (NumberOfElements < 0)
                    return null;
                return (-B + Math.Sqrt(Delta)) / (2 * a);
            }
        }

        public double P
        {
            get => -(B / (2 * a));
        }
        public double Q
        {
            get => -(Delta / (4 * a));
        }

        public string Vertex => $"({P}; {Q})";

        public Trinomial() { }

        public void UpdateProperties(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Delta"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NumberOfElements"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("X1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("X2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("P"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Q"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vertex"));
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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace PanDa
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    class IntToTextConverterClass : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value as string)
            {
                case "1":
                    return "Jeden";
                case "2":
                    return "Dwa";
                case "3":
                    return "Trzy";
                case "4":
                    return "Cztery";
                case "5":
                    return "Pięć";
                default:
                    return null;
            }
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture
        )
        {
            switch (value as string)
            {
                case "Jeden":
                    return "1";
                case "Dwa":
                    return "2";
                case "Trzy":
                    return "3";
                case "Cztery":
                    return "4";
                case "Pięć":
                    return "5";
                default:
                    return null;
            }
        }
    }

    class TextToBinaryConverterClass : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string t = value as string;
            switch (t)
            {
                case "Jeden":
                    return 1;
                case "Dwa":
                    return 10;
                case "Trzy":
                    return 11;
                case "Cztery":
                    return 100;
                case "Pięć":
                    return 101;
                default:
                    return null;
            }
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

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

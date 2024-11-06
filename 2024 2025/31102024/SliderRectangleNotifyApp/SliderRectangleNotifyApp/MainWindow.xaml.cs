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

namespace SliderRectangleNotifyApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    public class RectangleRGB : INotifyPropertyChanged
    {
        private int r,
            g,
            b;

        public int R
        {
            get => r;
            set
            {
                r = value;
                HandlePropertyChanged("R");
            }
        }

        public int G
        {
            get => g;
            set
            {
                g = value;
                HandlePropertyChanged("G");
            }
        }

        public int B
        {
            get => b;
            set
            {
                b = value;
                HandlePropertyChanged("B");
            }
        }

        public SolidColorBrush RectangleColor =>
            new SolidColorBrush(Color.FromRgb((byte)R, (byte)G, (byte)B));

        private void HandlePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RectangleColor"));
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

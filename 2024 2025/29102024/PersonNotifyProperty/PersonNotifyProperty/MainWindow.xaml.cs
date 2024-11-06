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

namespace PersonNotifyProperty
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    public class Person : INotifyPropertyChanged
    {
        #region fields
        string firstName,
            lastName;

        #endregion

        #region properties
        public string FirstName
        {
            get => firstName;
            set
            {
                if (firstName == value || string.IsNullOrWhiteSpace(value))
                    return;
                firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FullName"));
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName == value || string.IsNullOrWhiteSpace(value))
                    return;
                lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FullName"));
            }
        }

        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }
        #endregion

        #region constructors
        public Person() { }
        #endregion

        #region methods
        public override string ToString() =>
            $"Person[FirstName: {FirstName}, LastName: {LastName}, FullName: {FullName}]";
        #endregion

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

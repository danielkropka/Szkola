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
using SchoolClassApp.Classes;

namespace SchoolClassApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassesList.Items.Add(new Class("5TPI", "programista/informatyk", "K.B", 28));
        }

        private void ClassesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Class selectedItem = ClassesList.SelectedItem as Class;
            NameTB.Text = selectedItem.Name;
            StudentsTB.Text = $"{selectedItem.NumberOfStudents}";
            TeacherTB.Text = selectedItem.MainTeacher;
            ProfileTB.Text = selectedItem.Profile;
        }

        private void AddClass_Btn(object sender, RoutedEventArgs e)
        {
            int count = 0;
            if (!int.TryParse(StudentsTBox.Text, out count)) { }
            ClassesList.Items.Add(
                new Class(NameTBox.Text, ProfileTBox.Text, TeacherTBox.Text, count)
            );
        }

        private void Handle_Validation(object sender, TextChangedEventArgs e)
        {
            if (
                !string.IsNullOrWhiteSpace(NameTBox.Text)
                && !string.IsNullOrWhiteSpace(ProfileTBox.Text)
                && !string.IsNullOrWhiteSpace(TeacherTBox.Text)
                && int.TryParse(StudentsTBox.Text, out _)
            )
                AddBtn.IsEnabled = true;
            else
                AddBtn.IsEnabled = false;
        }
    }
}

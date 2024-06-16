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

namespace ListApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ItemsLB.SelectedIndex = 0;
            ListCountRun.Text = ItemsLB.Items.Count.ToString();
        }

        private void HandleTBChange(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null)
                return;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (AddElementBtn.IsEnabled)
                    AddElementBtn.IsEnabled = false;
                return;
            }
            if (!AddElementBtn.IsEnabled)
                AddElementBtn.IsEnabled = true;
        }

        private void AddElementToList(object sender, RoutedEventArgs e)
        {
            int index = ItemsLB.Items.Add(NewElementTB.Text);
            NewElementTB.Text = string.Empty;
            ListCountRun.Text = ItemsLB.Items.Count.ToString();
            ItemsLB.SelectedIndex = index;
        }

        private void DeleteElementFromList(object sender, RoutedEventArgs e)
        {
            ItemsLB.Items.RemoveAt(ItemsLB.SelectedIndex);
            CurrentSelectedItem.Text = string.Empty;
            ListCountRun.Text = ItemsLB.Items.Count.ToString();
        }

        private void HandleSelectionLB(object sender, SelectionChangedEventArgs e)
        {
            if (ItemsLB.SelectedItems.Count == 0)
            {
                if (DeleteElementBtn.IsEnabled)
                    DeleteElementBtn.IsEnabled = false;
            }
            else
            {
                if (!DeleteElementBtn.IsEnabled)
                    DeleteElementBtn.IsEnabled = true;
            }
            CurrentSelectedItem.Text =
                ItemsLB.SelectedItem == null ? string.Empty : ItemsLB.SelectedItem.ToString();
        }
    }
}

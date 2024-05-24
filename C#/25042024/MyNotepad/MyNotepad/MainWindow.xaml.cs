using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using Microsoft.Win32;

namespace MyNotepad
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region fields
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        string filePath;
        bool isSaved;
        #endregion

        #region constructors
        public MainWindow()
        {
            InitializeComponent();

            filePath = string.Empty;

            openFileDialog = new OpenFileDialog
            {
                Title = "Otwórz plik",
                Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*",
                FilterIndex = 1
            };
            saveFileDialog = new SaveFileDialog
            {
                Title = "Zapisz jako",
                Filter = openFileDialog.Filter,
                FilterIndex = 1,
            };

            TextWrappingMItem.IsChecked = true;
            MainTB.Focus();
        }
        #endregion

        #region methods
        private void SaveFile(string path)
        {
            filePath = path;
            File.WriteAllText(path, MainTB.Text, Encoding.UTF8);
            StatusBarTB.Text = Path.GetFileName(path);
            isSaved = true;
        }

        private void OpenFile(string path)
        {
            filePath = path;
            MainTB.Text = File.ReadAllText(path);
            StatusBarTB.Text = Path.GetFileName(path);
            isSaved = true;
        }

        private void OpenMItem(object sender, RoutedEventArgs e)
        {
            if (filePath != string.Empty)
            {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(filePath);
                openFileDialog.FileName = Path.GetFileName(filePath);
            }
            bool? result = openFileDialog.ShowDialog();
            if (result.HasValue && result.Value)
                OpenFile(openFileDialog.FileName);
        }

        private void SaveMItem(object sender, RoutedEventArgs e)
        {
            if (filePath != string.Empty)
            {
                SaveFile(filePath);

                return;
            }

            bool? result = saveFileDialog.ShowDialog();
            if (result.HasValue && result.Value)
                SaveFile(saveFileDialog.FileName);
        }

        private void SaveAsMItem(object sender, RoutedEventArgs e)
        {
            if (filePath != string.Empty)
            {
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(filePath);
                saveFileDialog.FileName = Path.GetFileName(filePath);
            }

            bool? result = saveFileDialog.ShowDialog();
            if (result.HasValue && result.Value)
                SaveFile(saveFileDialog.FileName);
        }

        private void TextNoWrapMItem(object sender, RoutedEventArgs e) =>
            MainTB.TextWrapping = TextWrapping.NoWrap;

        private void TextWrapMItem(object sender, RoutedEventArgs e) =>
            MainTB.TextWrapping = TextWrapping.Wrap;

        private void CloseMItem(object sender, RoutedEventArgs e)
        {
            if (!isSaved)
                SaveMItem(sender, e);
            Close();
        }

        private void TextInputMItem(object sender, TextChangedEventArgs e)
        {
            if (isSaved)
                isSaved = false;
        }
        #endregion
    }
}

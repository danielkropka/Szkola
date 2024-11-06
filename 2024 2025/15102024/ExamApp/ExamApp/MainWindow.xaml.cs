using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using ExamApp.Classes;

namespace ExamApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Record[] records;
        private int currentRecord = 0;

        void UpdateFieldsOnStart()
        {
            string[] lines = File.ReadAllLines("Data.txt");
            records = new Record[(int)Math.Round((double)lines.Length / 6)];

            int j = 0;
            for (int i = 0; i < records.Length; i++)
            {
                records[i] = new Record(
                    lines[j],
                    lines[j + 1],
                    int.Parse(lines[j + 2]),
                    int.Parse(lines[j + 3]),
                    int.Parse(lines[j + 4])
                );
                j += 6;
                Console.WriteLine(records[i] + "\n");
            }

            UpdateRecord();
        }

        void UpdateRecord(int record = 0)
        {
            NameOfArtist.Content = records[record].Artist;
            NameOfAlbum.Content = records[record].Album;
            CountOfSongs.Content = $"{records[record].SongsNumber} utworów";
            YearOfRelease.Content = records[record].YearOfEdition;
            NumberOfDownloads.Content = records[record].DownloadNumber;
        }

        public MainWindow()
        {
            InitializeComponent();
            UpdateFieldsOnStart();
        }

        private void NextRecordButton_Click(object sender, RoutedEventArgs e)
        {
            currentRecord++;
            if (currentRecord >= records.Length)
                currentRecord = 0;
            UpdateRecord(currentRecord);
        }

        private void PreviousRecordButton_Click(object sender, RoutedEventArgs e)
        {
            currentRecord--;
            if (currentRecord <= 0)
                currentRecord = records.Length - 1;
            UpdateRecord(currentRecord);
        }

        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            NumberOfDownloads.Content = ++records[currentRecord].DownloadNumber;
            string[] lines = new string[records.Length * 6];
            for (int i = 0; i < records.Length; i++)
            {
                lines[6 * i] = records[i].Artist;
                lines[6 * i + 1] = records[i].Album;
                lines[6 * i + 2] = records[i].SongsNumber.ToString();
                lines[6 * i + 3] = records[i].YearOfEdition.ToString();
                lines[6 * i + 4] = records[i].DownloadNumber.ToString();
                lines[6 * i + 5] = " ";
            }
            File.WriteAllLines("Data.txt", lines);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    internal class Record
    {
        public string Artist,
            Album;
        public int SongsNumber,
            YearOfEdition,
            DownloadNumber;

        public Record(
            string artist,
            string album,
            int songsNumber,
            int yearOfEdition,
            int downloadNumber
        )
        {
            Artist = artist;
            Album = album;
            SongsNumber = songsNumber;
            YearOfEdition = yearOfEdition;
            DownloadNumber = downloadNumber;
        }

        public override string ToString()
        {
            return $"{Artist}\n{Album}\n{SongsNumber}\n{YearOfEdition}\n{DownloadNumber}";
        }
    }
}

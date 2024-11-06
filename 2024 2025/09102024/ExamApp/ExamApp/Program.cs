using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    class Program
    {
        static Record[] records;

        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}

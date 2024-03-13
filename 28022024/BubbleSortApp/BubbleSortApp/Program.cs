using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp
{
    internal class Program
    {
        static void BubbleSort(int[] t, bool sortByAsc = true)
        {
            for (int i = t.Length; i > 0; i--)
                for(int j = 0; j < t.Length - 1; j++)
                    if (t[j] > t[j + 1])
                        (t[j], t[j + 1]) = (t[j + 1], t[j]);
        }
        static int SumAllElements(int[] t)
        {
            int sum = 0;
            foreach (int i in t)
                sum += i;
            return sum;
        }
        static double Average(int[] t)
        {
            return SumAllElements(t) / t.Length;
        }
        static void CountAllElements(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < t.Length; j++)
                    if (t[i] == t[j])
                        count++;
                Console.WriteLine($"{t[i]}: {count} razy");
            }
        }
        static double Median(int[] t)
        {
            int middle = t.Length / 2;
            if (t.Length % 2 == 0)
                return (double)(t[middle - 1] + t[middle]) / 2;
            return t[middle];
        }
        static void Main(string[] args)
        {
            int[] t = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(1, 11);
                Console.Write($"{i}:{t[i]}, ");
            }

            BubbleSort(t, true);
            Console.WriteLine("\n\n");
            for (int i = 0; i < t.Length; i++)
                Console.Write($"{i}:{t[i]}, ");

            Console.WriteLine($"Suma: {SumAllElements(t)}");
            Console.WriteLine($"Średnia: {Average(t)}");
            Console.WriteLine($"Median: {Median(t)}");
            Console.WriteLine("\n");
            CountAllElements(t);
            Console.ReadKey();
        }
    }
}

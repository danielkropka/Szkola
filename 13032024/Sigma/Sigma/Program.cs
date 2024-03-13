using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigma
{
    internal class Program
    {
        static void Init(int[] t, int from = 1, int to = 1000)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(from, to + 1);
        }

        static void ShowArray(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
                Console.Write($"{i}: {t[i]}, ");
        }

        static void BubbleSort(int[] t)
        {
            for(int i = t.Length - 1; i >= 0; i--)
                for(int j = 0; j < t.Length - 1; j++)
                    if (t[j] > t[j + 1])
                        (t[j], t[j + 1]) = (t[j + 1], t[j]);
        }

        static void ReverseArray(int[] t)
        {
            int j = t.Length - 1;
            for (int i = 0; i < t.Length / 2; i++)
            {
                (t[i], t[j]) = (t[j], t[i]);
                j--;
            }
        }

        static double Median(int[] t)
        {
            int half = t.Length / 2;
            if (t.Length % 2 == 0)
                return (double)t[half - 1] + t[half] / 2;
            return t[half];
        }
        static void Main(string[] args)
        {
            int[] t = new int[100];

            Init(t);
            ShowArray(t);
            Console.WriteLine("\n");

            BubbleSort(t);
            Console.WriteLine("\n");
            ShowArray(t);

            ReverseArray(t);
            Console.WriteLine("\n");
            ShowArray(t);

            Console.WriteLine($"\nMediana: {Median(t)}");
            Console.ReadKey();
        }
    }
}

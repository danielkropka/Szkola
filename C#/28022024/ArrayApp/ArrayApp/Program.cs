using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    internal class Program
    {
        static void Init(int[] t, int minValue, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(minValue, maxValue + 1);
        }

        static void Swap(int[] t, int firstIndex, int secondIndex)
        {
            Console.WriteLine("Przed zmianą");
            for (int i = 0; i < t.Length; i++)
                Console.Write($"{i}: {t[i]}, ");

            (t[secondIndex], t[firstIndex]) = (t[firstIndex], t[secondIndex]);
            Console.WriteLine("\nPo zmianie");
            for (int i = 0; i < t.Length; i++)
                Console.Write($"{i}: {t[i]}, ");
        }
        static void Main(string[] args)
        {
            int[] t = new int[10];
            Init(t, 0, 101);

            Swap(t, 0, 9);
            Console.ReadKey();
        }
    }
}

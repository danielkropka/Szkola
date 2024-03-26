using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static int[] FindTheBiggest(int[] tablica)
        {
            int[] tmp = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int max = int.MinValue;
                foreach (int value in tablica)
                    if (value > max && !Array.Exists(tmp, element => element == value))
                        max = value;
                tmp[i] = max;
            }

            return tmp;
        }

        static void Main(string[] args)
        {
            int[] t = new int[10];
            Random rand = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rand.Next(1, 101);
            }

            for(int i = 0; i < t.Length; i++)
                Console.Write($"{i}: {t[i]}, ");

            int[] theBiggest = FindTheBiggest(t);

            Console.WriteLine("Trzy największe liczby w tablicy:");
            foreach (int value in theBiggest)
                Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}

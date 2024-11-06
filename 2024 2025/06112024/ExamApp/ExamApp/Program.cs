using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    internal class Program
    {
        const int ARRAY_SIZE = 50;

        public static void Init(int[] t, int min = 1, int max = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
                t[i] = rnd.Next(min, max + 1);
        }

        public static int FindElement(int[] t, int element)
        {
            t[ARRAY_SIZE] = element;
            int i = 0;
            while (t[i] != element)
                i++;
            return i;
        }

        public static void Show(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
                Console.Write($"{i}: {t[i]}, ");
        }

        static void Main(string[] args)
        {
            int[] t = new int[ARRAY_SIZE + 1];
            Init(t);
            Console.WriteLine("Wprowadź szukaną liczbę: ");
            int index = FindElement(t, int.Parse(Console.ReadLine()));
            Console.WriteLine(index == ARRAY_SIZE ? "Znaleziono wartownika" : $"Indeks {index}");
            Show(t);
            Console.ReadKey();
        }
    }
}

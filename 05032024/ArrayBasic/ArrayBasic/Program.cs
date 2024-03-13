using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    internal class Program
    {
        static void Init(int[] t, int min = 1, int max = 1000)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(min, max + 1);
        }

        static void ShowArray(int[] t)
        {
            for (int i = 0;i < t.Length;i++)
                Console.Write($"{i}: {t[i]}, ");
        }

        static int FindMinValue(int[] t)
        {
            int min = t[0];
            for (int i = 0; i < t.Length - 1; i++)
                if (t[i] < min)
                    min = t[i];
            return min;
        }

        static int CountRepeated(int[] t, int needle)
        {
            int count = 0;
            for (int i = 0; i < t.Length; i++)
                if (t[i] == needle)
                    count++;
            return count;
        }
        static void Main(string[] args)
        {
            int[] t = new int[10];
            Init(t, 1, 10);
            ShowArray(t);
            Console.WriteLine(FindMinValue(t));
            int minValue = FindMinValue(t);
            Console.WriteLine($"Liczba minimalna: {minValue} Powtarza się: {CountRepeated(t, minValue)} razy");
            Console.ReadKey();
        }
    }
}

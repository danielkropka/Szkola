using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElementApp
{
    internal class Program
    {
        static void ShowArray(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
                Console.Write($"{i}: {t[i]}, ");
        }
        static bool FindElement(int[] t, int n)
        {
            foreach (int item in t)
                if (item == n)
                    return true;
            return false;
        }

        static int FindIndexOfElement(int[] t, int n)
        {
            for(int i = 0;i < t.Length; i++)
                if (t[i] == n) return i;

            return -1;
        }

        static int FindLastIndexOf(int[] t, int n)
        {
/*            int index = -1;
            for (int i = 0; i < t.Length; i++)
                if (t[i] == n) index = i;

            return index;*/
            for(int i = t.Length;i > -1; i--)
                if (t[i] == n) return i;

            return -1;
        }
        static void Main(string[] args)
        {
            int[] t = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(1, 11);

            ShowArray(t);
            Console.WriteLine(FindElement(t, 10) ? "\nZnaleziono" : "\nNie znaleziono");
            Console.WriteLine("\n");
            Console.WriteLine(FindIndexOfElement(t, 10));
            Console.WriteLine(FindLastIndexOf(t, 10));
            Console.ReadKey();
        }
    }
}

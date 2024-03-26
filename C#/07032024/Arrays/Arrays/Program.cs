using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void InitArray(int[] t, int minValue = 1, int maxValue = 1000)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(minValue, maxValue + 1);
        }

        static void ShowArray(int[] t, bool showIndex = true)
        {
            for (int i = 0; i < t.Length; i++)
                Console.Write(showIndex ? $"{i}: {t[i]}, " : $"{t[i]}, ");
        }

        static int Guardian(int[] t, int needle)
        {
/*            int[] tmp = new int[t.Length + 1];
            t.CopyTo(tmp, 0);*/
            t[t.Length - 1] = needle;

            for (int i = 0; i < t.Length; i++)
                if (t[i] == needle)
                    return i;
            return -1;
        }

        static int Validation(string label)
        {
            int needle;
            bool isParsed = true;
            do 
            {
                Console.WriteLine($"\n{label}");
                if(int.TryParse(Console.ReadLine(), out needle))
                    isParsed = false;
                else
                    Console.WriteLine("Podano błędne dane!");

            } while (isParsed);
            return needle;
        }

        static void Main(string[] args)
        {

            int[] t = new int[11];

            InitArray(t, 1, 10);
            ShowArray(t);

            int index = Guardian(t, Validation("Podaj liczbe: "));
            Console.WriteLine($"Index: {index}");

            Console.ReadKey();
        }
    }
}

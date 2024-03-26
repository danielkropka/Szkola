using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stomia
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

        static int GetIndexOfMin(int[] t) 
        {
            int result = 0;
            for (int i = 0; i < t.Length; i++)
                if (t[i] < t[result])
                    result = i;
            return result;
        }
        static void Main(string[] args)
        {
            int[] t = new int[100];
            InitArray(t, 1, 10);
            ShowArray(t);
            Console.WriteLine("\n");
            ShowArray(t, false);

            Console.WriteLine($"\n{GetIndexOfMin(t)}");
            Console.ReadKey();

        }
    }
}

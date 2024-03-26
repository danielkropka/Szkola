using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxMinArrayApp
{
    internal class Program
    {
        static int GetMaxValueOf(int[] t) 
        {
            int result = t[0];
            for (int i = 1; i < t.Length; i++)
                if (t[i] > result)
                    result = t[i];
            return result;
        }

        static int GetMinValueOf(int[] t)
        {
            int result = t[0];
            for (int i = 1; i < t.Length; i++)
                if (t[i] < result)
                    result = t[i];
            return result;
        }

        static int GetIndexOfMax(int[] t)
        {
            int result = 0;
            for (int i = 0; i < t.Length; i++)
                if (t[i] > t[result])
                    result = i;
            return result;
        }

        static (int, int) GetIndexAndMaxOf(int[] t)
        {
            int result = 0;
            for (int i = 0; i < t.Length; i++)
                if (t[i] > t[result])
                    result = i;
            return (result, t[result]);
        }

        static int GetAmountOf(int[] t, int n)
        {
            int result = 0;
            for(int i = 0; i < t.Length; i++)
                if (t[i] == n) result++;
            return result;
        }

        static void Main(string[] args)
        {
            int[] t = new int[15];
            Random rnd = new Random();

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(1, 13);
                Console.WriteLine($"{i}: {t[i]}, ");
            }

            Console.WriteLine(GetMaxValueOf(t));
            Console.WriteLine(GetMinValueOf(t));
            Console.WriteLine(GetIndexOfMax(t));

            (int index, int value) = GetIndexAndMaxOf(t);
            Console.WriteLine($"{index}: {value}");
            Console.WriteLine($"Powtarza się: {GetAmountOf(t, 5)}");
            Console.ReadKey();
        }
    }
}

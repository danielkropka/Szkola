using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    internal class Program
    {

        static void Init(int[] t, int from = 1, int to = 1001)
        {
            Random rnd = new Random();
            for(int i  = 0; i < t.Length; i++)
                t[i] = rnd.Next(from , to);
        }
        static void ShowArray(int[] t)
        {
            for(int i = 0;i < t.Length;i++)
                Console.Write($"{i}: {t[i]}, ");
        }

        static void SwapArray(int[] t)
        {
            int count = t.Length - 1;
            for (int i = 0; i < t.Length / 2; i++)
            {
                (t[i], t[count]) = (t[count], t[i]);
                count--;
            }
            ShowArray(t);
        }

        static bool FindElement(int[] t, int n)
        {
            for (int i = 0; i < t.Length; i++)
                if (t[i] == n)
                    return true;
            return false;
        }

        static int CountRepeated(int[] t, int n)
        {
            int count = 0;
            for (int i = 0; i < t.Length; i++)
                if (t[i] == n)
                     count++;
            return count;
        }

        static void ShowNotRepeat(int[] t)
        {
            int[] tmp = new int[t.Length];
            int counter = 0;
            for (int i = 0; i < t.Length; i++)
                if (!FindElement(tmp, t[i]))
                {
                    Console.Write($"{t[i]}: {CountRepeated(t, t[i])} razy, ");
                    tmp[counter++] = t[i];
                }

        }
        static void Main(string[] args)
        {
            int[] t = new int[10];
            Init(t, 1, 10);
            ShowArray(t);
            Console.WriteLine("\n");
            SwapArray(t);
            Console.WriteLine("\n");
            ShowNotRepeat(t);
            Console.ReadKey();
        }
    }
}

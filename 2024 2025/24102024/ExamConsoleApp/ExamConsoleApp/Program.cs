using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsoleApp
{
    internal class Program
    {
        static void Init(bool[] t)
        {
            for (int i = 0; i < t.Length; i++)
                t[i] = true;
        }

        static bool[] Algorithm(bool[] t)
        {
            for (int i = 2; i < Math.Sqrt(t.Length); i++)
            {
                if (t[i])
                {
                    for (int j = i * i; j < t.Length; j += i)
                    {
                        t[j] = false;
                    }
                }
            }

            return t;
        }

        static void Show(bool[] t)
        {
            for (int i = 2; i < t.Length; i++)
            {
                if (t[i])
                    Console.WriteLine($"{i}: {t[i]}");
            }
        }

        static void Main(string[] args)
        {
            const int n = 100;
            bool[] A = new bool[n];
            Init(A);
            Show(Algorithm(A));

            Console.ReadKey();
        }
    }
}

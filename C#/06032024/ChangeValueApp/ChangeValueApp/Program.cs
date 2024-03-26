using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeValueApp
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

        static void ShowArray(double[] t, bool showIndex = true)
        {
            for (int i = 0; i < t.Length; i++)
                Console.Write(showIndex ? $"{i}: {t[i]}, " : $"{t[i]}, ");
        }

        static void ChangeMinusToZero(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
                if (t[i] < 0)
                    t[i] = 0;
        }

        static int GetSecondMaxElement(int[] t)
        {
            int result = t[0];
            for (int i = 0; i < t.Length; i++)
                if (t[i] > result && t[i] < t.Max())
                    result = t[i];
            return result;
        }

        static double[] Standarization(int[] t)
        {
            double[] result = new double[t.Length];
            double maxElement = t.Max();

            for (int i = 0; i < t.Length; i++)
                result[i] = t[i] / maxElement;

            return result;
        }

        static int GetIndexOf(int[] t, bool lookForMin = true)
        {
            int index = 0;
            for (int i = 0; i < t.Length; i++)
                if (lookForMin ? t[i] < t[index] : t[i] > t[index])
                    index = i;
            return index;
        }

        static int GetMinAndSwapToMax(int[] t)
        {
            int[] result = (int[])t.Clone();
            int min = result.Min(),
                max = result.Max();

            for (int i = 0; i < result.Length; i++)
                if (result[i] == max)
                    result[i] = min;

            return result.Max();
        }

/*        static void GetThreeMax(int[] t)
        {
            int count = 0;
            int result = t[0];
            for (int i = 0; i < t.Length; i++)
                if (t[i] > result && result < t.Max() && count < 3)
                {
                    result = t[i];
                    count++;
                    Console.WriteLine($"{count} największa liczba: {result}");
                }
        }*/

        static bool FindElement(int[] t, int needle, int startIndex, int stopIndex)
        {
            for (int i = startIndex; i < stopIndex + 1; i++)
                if (t[i] == needle)
                    return true;
            return false;
        }

        static int[] GetNotRepeated(int[] t)
        {
            int[] tmp = new int[t.Length];

            int count = 0;
            for (int i = 0; i < t.Length; i++)
                if (!FindElement(tmp, t[i], 0, count))
                {
                    tmp[count] = t[i];
                    count++;
                }

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
                result[i] = tmp[i];

            return result;
        } 
        
        static void Eratostenesa()
        {
            const int n = 100;
            bool[] a = new bool[n];
            for (int i = 0; i < a.Length; i++)
                a[i] = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (a[i])
                    for (int j = 2; j * i < n; j++)
                        a[j * i] = false;

            for (int i = 2; i < n; i++)
                if (a[i])
                    Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
        /*    int[] t = new int[10];
            InitArray(t, 1, 10);
            ShowArray(t);
            *//*            ShowArray(Standarization(t));
                        Console.WriteLine("\n");
                        ShowArray(t);
                        Console.WriteLine("\n");
                        Console.WriteLine(GetSecondMaxElement(t));*/
            /*            ShowArray(t);
                        Console.WriteLine("\n");

                        Console.WriteLine(GetMinAndSwapToMax(t));

                        Console.WriteLine("\n");
                        ShowArray(t);*/

            /*            InitArray(t, -100, 100);
                        ShowArray(t);
                        ChangeMinusToZero(t);
                        ShowArray(t);*//*
            int[] t1 = GetNotRepeated(t);
            Console.WriteLine("\n");
            ShowArray(t1);*/
            Eratostenesa();
            Console.ReadKey();
        }
    }
}

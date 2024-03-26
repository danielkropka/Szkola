using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorzeniewojtek
{
    delegate int ArrayDelegate();
    delegate int InitIndexDelegate(int index);
    internal class Program
    {
        static void InitArray(int[] t, int minValue = 1, int maxValue = 1000)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(minValue, maxValue + 1);
        }

        static void InitPro(int[] t, ArrayDelegate callback)
        {
            for (int i = 0; i < t.Length; i++)
                t[i] = callback();
        }

        static void InitPro(int[] t, InitIndexDelegate callback)
        {
            for (int i = 0; i < t.Length; i++)
                t[i] = callback(i);
        }

        static void ShowArray(int[] t, bool showIndex = true)
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

        static bool FindElement(int[] t, int needle, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex + 1 ; i++)
                if (t[i] == needle)
                    return true;
            return false;
        }

        /*        static int[] GetThreeMax(int[] t)
                {
                    int[] tmp = new int[3];
                    for (int i = 0; i < 3; i++)
                    {
                        int result = t[0];
                        foreach (int value in t)
                            if (value > result && !FindElement(tmp, value, 0, t.Length))
                                result = value;
                        tmp[i] = result;
                    }
                    return tmp;
                }*/

        static void BubbleSort(int[] t, bool sortByAsc = true)
        {
            for (int i = t.Length; i > 0; i--)
                for (int j = 0; j < t.Length - 1; j++)
                    if (sortByAsc ? t[j] > t[j + 1] : t[j] < t[j + 1])
                        (t[j], t[j + 1]) = (t[j + 1], t[j]);
        }

        static int GetIndexOfMin(int[] t, int start = 0)
        {
            int result = start;
            for (int i = start; i < t.Length; i++)
                if (t[i] < t[result])
                    result = i;
            return result;
        }

        static void SelectSort(int[] t)
        {
            int indexOfMin;
            for (int i = 0; i < t.Length; i++)
            {
                indexOfMin = GetIndexOfMin(t, i);
                (t[i], t[indexOfMin]) = (t[indexOfMin], t[i]);
            }
            ShowArray(t);
        }

        static int[] GetNotRepeated(int[] t)
        {
            int[] tmp = new int[t.Length];

            int count = 0;
            for (int i = 0; i < t.Length; i++)
                if (!FindElement(tmp, t[i], 0, count))
                    tmp[count++] = t[i];

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
                result[i] = tmp[i];
            return result;
        }

        static void Main(string[] args)
        {
            int[] t = new int[10];
            Random r = new Random();
            InitArray(t, 1, 10);
/*            InitPro(t, () =>
            {
                return r.Next(1, 11);
            });
            InitPro(t, (i) =>
            {
                if (i % 2 == 0)
                    return 0;
                return 1;
            });*/
            ShowArray(t);
            Console.WriteLine("\n");
            /*            ShowArray(GetThreeMax(t));*/
            ShowArray(GetNotRepeated(t));
            Console.ReadKey();
        }
    }
}

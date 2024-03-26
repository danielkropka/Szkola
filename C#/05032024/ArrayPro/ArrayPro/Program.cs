using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPro
{
    delegate int ArrayDelegate();
    delegate int InitIndexDelegate(int index);
    internal class Program
    {
        #region tools
        static void Init(int[] t, int min = 1, int max = 1000)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(min, max + 1);
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

        static int GetMin(int[] t, int start = 0)
        {
            int result = t[start];
            for(int i = start; i < t.Length; i++)
                if (t[i] < result)
                    result = t[i];
            return result;
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
            for(int i = 0; i < t.Length; i++)
            {
                indexOfMin = GetIndexOfMin(t, i);
                (t[i], t[indexOfMin]) = (t[indexOfMin], t[i]);
            }
            ShowArray(t);
        }

        /*static void SortWojtaszek(int[] t)
        {
            int[] tmp = new int[t.Length];
            int index;
            int i, j;
            for (i = 0; i < t.Length - 1; i++)
            {
                index = 0;
                for (j = 0; j < i; j++)
                    if (t[j] < tmp[index])
                        break;
                index = j;
                for (j = tmp.Length - 1; j > index; j--)
                    tmp[j] = tmp[j - 1];
                tmp[index] = t[i];

            }

            for(i = 0; i < t.Length; i++)
                t[i] = tmp[i];
            
            ShowArray(t);
        }*/

        static void ShowArray(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
                Console.Write($"{i}: {t[i]}, ");
        }

        #endregion
/*        static int Initcos(int index)
        {
            Random random = new Random();
            return random.Next(1, 100);
        }*/

        static void Main(string[] args)
        {
            int[] t = new int[10];
            Random rnd = new Random();
            InitPro(t, (i) =>
            {
                if (i % 2 == 0)
                    return 0;
                return 1;
            });

            /*InitPro(t, Initcos);*/
            Console.WriteLine();
            ShowArray(t);
            /*SortWojtaszek(t);*/
            Console.ReadKey();
        }
    }
}

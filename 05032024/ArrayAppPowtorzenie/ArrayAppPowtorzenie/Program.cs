using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAppPowtorzenie
{
    internal class Program
    {
        static void Init(int[] t, int min = 1, int max = 1000)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(min, max + 1);
        }

        static void ShowArray(int[] t, bool showIndex = true)
        {
            if(showIndex)
            {
                for (int i = 0; i < t.Length; i++)
                    Console.Write($"{i}: {t[i]}, ");
            }
            else
            {
                Console.Write(string.Join(", ", t));
/*                foreach (int i in t)
                    Console.Write($"{i}, ");*/
            }

        }

        static int FindMinElement(int[] t)
        {
            int minValue = t[0];
            for(int i = 0; i < t.Length; i++)
                if (t[i] < minValue)
                    minValue = t[i];
            return minValue;
        }

        static int FindMaxElement(int[] t)
        {
            int maxValue = t[0];
            for (int i = 0; i < t.Length; i++)
                if (t[i] > maxValue)
                    maxValue = t[i];
            return maxValue;
        }

        static int GetAppearance(int[] t, int needle)
        {
            int count = 0;
            for(int i = 0; i < t.Length; i++)
                if (t[i] == needle)
                    count++;
            return count;
        }

        static bool FindElementInArray(int[] t, int needle)
        {
            for(int i = 0; i < t.Length; i++)
                if (t[i] == needle)
                    return true;
            return false;
        }

        static int FindIndexOfElement(int[] t, int needle)
        {
            for (int i = 0; i < t.Length; i++)
                if (t[i] == needle)
                    return i;
            return -1;
        }

        static (int, int) GetIndexAndMin(int[] t)
        {
            int result = 0;
            for (int i = 0; i < t.Length; i++)
                if (t[i] < t[result])
                    result = i;
            return (result, t[result]);
        }

        static void Swap(int[] t, int firstIndex, int secondIndex)
        {
            int tmp = t[firstIndex];
            Console.WriteLine("\nPrzed zmianą: ");
            ShowArray(t);
            t[firstIndex] = t[secondIndex];
            t[secondIndex] = tmp;
            /*(t[firstIndex], t[secondIndex]) = (t[secondIndex], t[firstIndex]);*/
            Console.WriteLine("\nPo zmianie: ");
            ShowArray(t);
        }

        static int Sum(int[] t)
        {
            int result = 0;
            for (int i = 0; i < t.Length; i++)
                result += t[i];
            return result;
        }

        static void Main(string[] args)
        {
            int[] t = new int[10];
            Init(t, 1, 10);
            ShowArray(t);
            int minValue = FindMinElement(t);
            int maxValue = FindMaxElement(t);
            Console.WriteLine($"Najmniejsza liczba: {minValue}");
            Console.WriteLine($"Największa liczba: {maxValue}");

            int n = GetAppearance(t, minValue);
            Console.WriteLine($"Liczba {minValue} powtarza się {n} razy");

            Console.WriteLine(FindElementInArray(t, 5) ? "Jest" : "Nie ma");
            Console.WriteLine(FindIndexOfElement(t, 5));

            (int index, int value) = GetIndexAndMin(t);
            Console.WriteLine($"\n{index}, {value}");
            /*Swap(t, 0, 9);*/
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternApp
{
    delegate void PatternDelegate(int n);
    internal class Program
    {
        static void PatternVertical(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine("*");
        }
        static void PatternHorizontal(int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write("*");
        }

        static void Pattern(PatternDelegate pattern) 
        {
            int n;
            bool isParsed = true;
            do
            {
                Console.WriteLine("Podaj liczbę gwiazdek: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                    Console.WriteLine("Błędne dane!");
                else 
                    isParsed = false;
            } while (isParsed);
            pattern(n);
        }

        static void Main(string[] args)
        {
            Pattern(PatternHorizontal);
            Console.ReadKey();

        }
    }
}

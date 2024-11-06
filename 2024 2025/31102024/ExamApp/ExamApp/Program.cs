using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Euklides
    {
        private int a,
            b;
        bool isParsed = false;

        public Euklides()
        {
            while (!isParsed || a < 1 || b < 1)
            {
                Console.WriteLine("Podaj a:");
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Podaj b:");
                    if (int.TryParse(Console.ReadLine(), out b))
                        isParsed = true;
                }
            }

            Console.WriteLine(NWD(a, b));
        }

        public int NWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Euklides euklide = new Euklides();

            Console.ReadKey();
        }
    }
}

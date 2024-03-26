using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApp
{
    delegate void ShowResult(bool isTriangle);
    internal class Program
    {

        static int Validation(string text)
        {
            int n;
            bool isParsed = true;
            do
            {
                Console.WriteLine(text);
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                    Console.WriteLine("Podano błędne dane!");
                else isParsed = false;

            } while (isParsed);
            return n;
        }

        static void ShowPL(bool isTriangle)
        {
            if (isTriangle)
                Console.WriteLine("Jest");
            else 
                Console.WriteLine("Nie jest");
        }

        static void ShowEN(bool isTriangle)
        {
            Console.WriteLine(isTriangle ? "Yes yes yes" : "No no no");
        }

        static void Engine(ShowResult show)
        {
            int a, b, c;
            a = Validation("Podaj bok A: ");
            b = Validation("Podaj bok B: ");
            c = Validation("Podaj bok C: ");

            show(a + b > c && a + c > b && b + c > a);
        }
        static void Main(string[] args)
        {
            Engine(ShowEN);
            Console.ReadKey();
        }
    }
}

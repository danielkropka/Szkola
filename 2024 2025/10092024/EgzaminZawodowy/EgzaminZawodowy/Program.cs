using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgzaminZawodowy.Classes;

namespace EgzaminZawodowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choose = "t";
            while (choose == "t")
            {
                Game game = new Game();
                Console.WriteLine("Jeszcze raz? (t/n)");
                choose = Console.ReadLine();
            }
        }
    }
}

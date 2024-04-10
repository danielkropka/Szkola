using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintApp.Classes;

namespace PrintApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer(5, true);
            Console.WriteLine(printer);
            InkPrinter inkPrinter = new InkPrinter(5, 5, true);
            Console.WriteLine(inkPrinter);
            LaserPrinter laserPrinter = new LaserPrinter(220, 5, true);
            Console.WriteLine(laserPrinter);
            Console.ReadKey();
        }
    }
}

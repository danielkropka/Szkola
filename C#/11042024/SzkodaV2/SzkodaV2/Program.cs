using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkodaV2.Classes;

namespace SzkodaV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Package package = new Package("cos", 15);
            Bottle bottle = new Bottle("jakas nazwa", 30, 10);
            Box box = new Box("jakas nazwa 2", 5, 5);
            Console.WriteLine(package);
            Console.WriteLine(box);
            Console.WriteLine(bottle);
            Console.ReadKey();
        }
    }
}

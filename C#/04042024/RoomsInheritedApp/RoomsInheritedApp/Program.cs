using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomsInheritedApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bathroom bathroom = new Bathroom("wbs", 9, 6);
            Console.WriteLine(bathroom);
            Console.ReadKey();
        }
    }
}

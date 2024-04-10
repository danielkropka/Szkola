using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(0, 250);
            Console.WriteLine(vehicle);
            Car car = new Car(string.Empty, 0, 180);
            Console.WriteLine(car);
            car.Start(100);
            Console.WriteLine(car);
            Console.ReadKey();
        }
    }
}

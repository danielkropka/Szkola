using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritedApp.Classes;

namespace InheritedApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike romet = new Bike(40, 5);
            Console.WriteLine(romet);
            romet.Move();
            Console.WriteLine(romet);

            Car car = new Car("BEMWU", 120);
            Console.WriteLine(car);
            car.Move();
            Console.WriteLine(car);
            Console.ReadKey();
        }
    }
}

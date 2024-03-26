using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Car
    {
        #region
        public string Model, Brand;
        public int vMax;
        #endregion

        #region overriden
        public override string ToString()
        {
            return $"Car {Brand} {Model} {vMax}";
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car BMW = new Car();
            BMW.Brand = "BMW";
            BMW.Model = "M4";
            BMW.vMax = 305;

            Console.WriteLine(BMW);
            Console.ReadKey();
        }
    }
}

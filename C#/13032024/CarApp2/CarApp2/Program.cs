using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp2
{
    class Car
    {
        public string Name;
        public int Speed;
        public bool isMoving;

        public void SetCarState(bool state, int speed = 1)
        {
            isMoving = state;
            if (!state)
                Speed = 0;
            else
                Speed = speed;
        }
        public void SetName(string name) => Name = name;

        public override string ToString()
        {
            return $"Car[{Name} - {Speed} km/h, {(isMoving ? "Porusza się" : "Stoi")}]";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car golf = new Car();
            golf.SetName("Golf IV");
            golf.SetCarState(true, 150);

            Console.WriteLine(golf);
            Console.ReadKey();
        }
    }
}

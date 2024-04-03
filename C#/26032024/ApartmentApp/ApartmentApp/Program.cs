using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentApp
{
    class Room
    {
        private string name;
        private double area;

        #region property
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == name)
                    return;
                name = value;
            }
        }

        public double Area
        {
            get => area;
            set
            {
                if (value <= 0 || value == area)
                    return;
                area = value;
            }
        }
        #endregion
        #region constructor
        public Room()
        {
            Name = "noname";
            Area = 1;
        }

        public Room(string name, double area)
            : this()
        {
            Name = name;
            Area = area;
        }

        public Room(Room r)
            : this(r.Name, r.Area) { }
        #endregion
        public override string ToString() => $"Room[ Name: {Name}, Area: {Area}]";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Room kitchen = new Room("Kuchnia", 16);
            Room bathroom = new Room("Łazienka", 15);
            Room livingroom = new Room("Jadalnia", 20);

            Console.WriteLine(kitchen);
            Console.WriteLine(bathroom);
            Console.WriteLine(livingroom);
            Apartment a1 = new Apartment(1, kitchen, bathroom, livingroom);

            Console.WriteLine(a1);

            Console.ReadKey();
        }
    }
}

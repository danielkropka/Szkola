using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedApp.Classes
{
    internal class Car : Vehicle
    {
        string make;

        public string Make
        {
            get => make;
            set
            {
                if (make == value || string.IsNullOrWhiteSpace(value))
                    return;
                make = value;
            }
        }

        public Car() => Make = "Noname";

        public Car(string make, double vMax = 100, double v = 0)
            : base("Car", v, vMax) => Make = make;

        public override string ToString() => $"{Name}[V: {V}, VMax: {VMax}, Marka: {Make}]";
    }
}

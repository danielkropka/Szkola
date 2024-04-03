using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedApp
{
    internal class Vehicle
    {
        protected double v,
            vMax;
        protected string name;

        public double V
        {
            get => v;
            set
            {
                if (v == value || value < 0)
                    return;
                v = value;
            }
        }

        public double VMax
        {
            get => vMax;
            set
            {
                if (vMax == value || value <= 0)
                    return;
                vMax = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (name == value || string.IsNullOrWhiteSpace(value))
                    return;
                name = value;
            }
        }

        public Vehicle()
        {
            Name = "Noname";
            V = 0;
            VMax = 100;
        }

        public Vehicle(string name)
            : this() => Name = name;

        public Vehicle(string name, double v, double vMax)
            : this(name)
        {
            V = v;
            VMax = vMax;
        }

        public void Stop() => V = 0;

        public void Move(double v = 10) => V = v;

        public override string ToString() => $"Vehicle[Name: {Name}, V: {V}, VMax: {VMax}]";
    }
}

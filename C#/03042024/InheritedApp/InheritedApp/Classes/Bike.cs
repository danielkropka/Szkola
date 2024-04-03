using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedApp.Classes
{
    internal class Bike : Vehicle
    {
        int derailleur;

        public int Derailleur
        {
            get => derailleur;
            set
            {
                if (derailleur == value || value < 0)
                    return;
                derailleur = value;
            }
        }

        public Bike() => Derailleur = 0;

        public Bike(double vMax, int derailleur = 0, double v = 0)
            : base("Bike", v, vMax) => Derailleur = derailleur;

        public void SlowDown(double v)
        {
            this.v -= v;
            if (this.v < 0)
                this.v = 0;
        }

        public override string ToString() =>
            $"Bike[Przerzutka: {Derailleur}\n\t{base.ToString()}\n]";
    }
}

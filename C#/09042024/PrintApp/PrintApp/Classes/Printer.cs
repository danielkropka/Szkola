using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintApp.Classes
{
    internal class Printer
    {
        protected int sides;
        protected bool duplex;

        public int Sides
        {
            get => sides;
            set
            {
                if (value < 0)
                    return;
                sides = value;
            }
        }

        public bool Duplex { get; set; }

        public Printer()
        {
            Sides = 1;
            Duplex = true;
        }

        public Printer(int sides, bool duplex = false)
            : this()
        {
            Sides = sides;
            Duplex = duplex;
        }

        public override string ToString() =>
            $"Printer[{Sides} stron/min, {(Duplex ? "Dwustronny" : "Jednostronny")}]";
    }
}

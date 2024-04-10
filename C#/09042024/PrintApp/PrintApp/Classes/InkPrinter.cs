using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintApp.Classes
{
    internal class InkPrinter : Printer
    {
        int cartridges;

        public int Cartridges
        {
            get => cartridges;
            set
            {
                if (value == cartridges || value < 1)
                    return;
                cartridges = value;
            }
        }

        public InkPrinter() => Cartridges = 1;

        public InkPrinter(int cartridges)
            : this() => Cartridges = cartridges;

        public InkPrinter(int cartridges, int pages, bool duplex = false)
            : base(pages, duplex)
        {
            Cartridges = 1;
            Cartridges = cartridges;
        }

        public override string ToString() =>
            $"InkPrinter[Cartridges: {Cartridges}\n\t{base.ToString()}\n]";
    }
}

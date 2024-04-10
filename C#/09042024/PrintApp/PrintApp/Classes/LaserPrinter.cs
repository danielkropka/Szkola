using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintApp.Classes
{
    internal class LaserPrinter : Printer
    {
        double opcPrice;

        public double OPCPrice
        {
            get => opcPrice;
            set
            {
                if (value == opcPrice || value <= 0)
                    return;
                opcPrice = value;
            }
        }

        public LaserPrinter() => OPCPrice = 0;

        public LaserPrinter(double opcPrice)
            : this() => OPCPrice = opcPrice;

        public LaserPrinter(double opcPrice, int pages, bool duplex = false)
            : base(pages, duplex)
        {
            OPCPrice = 1;
            OPCPrice = opcPrice;
        }

        public override string ToString() => $"LaserPrinter[{base.ToString()}]";
    }
}

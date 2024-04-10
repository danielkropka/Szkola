using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomsInheritedApp
{
    internal class Kitchen : Room
    {
        int amountOfWaterConnections;

        public int AmountOfWaterConnections
        {
            get => amountOfWaterConnections;
            set
            {
                if (amountOfWaterConnections == value || amountOfWaterConnections < 0)
                    return;
                amountOfWaterConnections = value;
            }
        }

        public Kitchen() => AmountOfWaterConnections = 0;

        public Kitchen(int n)
            : this() => AmountOfWaterConnections = n;

        public Kitchen(double surface, double height, int n)
            : base(surface, height) => AmountOfWaterConnections = n;

        public override string ToString() =>
            $"Ilość przyłączeń wodnych: {AmountOfWaterConnections}\n\t{base.ToString()}";
    }
}

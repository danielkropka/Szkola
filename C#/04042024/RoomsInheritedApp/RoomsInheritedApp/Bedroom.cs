using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomsInheritedApp
{
    internal class Bedroom : Room
    {
        int bedWidth;

        public int BedWidth
        {
            get => bedWidth;
            set
            {
                if (bedWidth == value || value < 0)
                    return;
                bedWidth = value;
            }
        }

        public override string ToString() => $"";
    }
}

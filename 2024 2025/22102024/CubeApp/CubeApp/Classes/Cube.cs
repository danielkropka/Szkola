using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeApp.Classes
{
    internal class Cube
    {
        int numberOfStitches;
        int id;

        public int NumberOfStitches
        {
            get => numberOfStitches;
            set
            {
                if (numberOfStitches == value || value < 1 || value > 6)
                    return;
                numberOfStitches = value;
            }
        }

        public Cube(int id) => this.id = id;

        public override string ToString() => $"Kostka {id}: {NumberOfStitches}";
    }
}

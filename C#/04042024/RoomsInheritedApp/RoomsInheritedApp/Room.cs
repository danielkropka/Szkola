using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomsInheritedApp
{
    internal class Room
    {
        protected double surface,
            height;

        public double Surface
        {
            get => surface;
            set
            {
                if (surface == value || value <= 0)
                    return;
                surface = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (height == value || value <= 0)
                    return;
                height = value;
            }
        }

        public Room()
        {
            Surface = 1;
            Height = 1;
        }

        public Room(double surface, double height)
            : this()
        {
            Surface = surface;
            Height = height;
        }

        public override string ToString() => $"Room[Surface: {Surface}, Height: {Height}]";
    }
}

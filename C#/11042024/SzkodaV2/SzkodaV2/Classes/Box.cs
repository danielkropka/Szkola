using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkodaV2.Classes
{
    internal class Box : Package
    {
        #region field
        double height;
        #endregion

        #region property
        public double Height
        {
            get => height;
            set
            {
                if (value == height || value <= 0)
                    return;
                height = value;
            }
        }
        #endregion

        #region constructor
        public Box() => Height = 1;

        public Box(double height)
            : this() => Height = height;

        public Box(string name, double v, double height)
            : base(name, v)
        {
            Height = 1;
            Height = height;
        }
        #endregion

        public override string ToString() => $"Box[Height: {Height}, Name: {Name}, V: {V}]";
    }
}

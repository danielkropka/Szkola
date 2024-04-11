using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkodaV2.Classes
{
    internal class Bottle : Package
    {
        #region field
        double radius;
        #endregion
        #region property
        public double Radius
        {
            get => radius;
            set
            {
                if (radius == value || value <= 0)
                    return;
                radius = value;
            }
        }
        #endregion

        #region constructor
        public Bottle() => Radius = 1;

        public Bottle(double radius)
            : this() => Radius = radius;

        public Bottle(string name, double v, double radius)
            : base(name, v)
        {
            Radius = 1;
            Radius = radius;
        }
        #endregion

        public override string ToString() => $"Bottle[Radius: {Radius}\n\t{base.ToString()}\n]";
    }
}

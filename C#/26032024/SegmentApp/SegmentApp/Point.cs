using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentApp
{
    class Point
    {
        double x,
            y;

        #region property
        public double X
        {
            get => x;
            set
            {
                if (x == value)
                    return;
                x = value;
            }
        }

        public double Y
        {
            get => y;
            set
            {
                if (y == value)
                    return;
                y = value;
            }
        }

        public (double, double) FPoint => (x, y);
        #endregion

        #region constructor
        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y)
            : this()
        {
            X = x;
            Y = y;
        }

        public Point(Point p)
            : this(p.X, p.Y) { }
        #endregion

        public override string ToString() => $"Point[{FPoint}]";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentApp
{
    class Segment
    {
        Point p1,
            p2;

        #region property
        Point P1 => p1;
        Point P2 => p2;

        public double Length => Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p2.X, 2));
        public Point Middle => new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        #endregion
        #region constructor
        public Segment()
        {
            p1 = new Point();
            p2 = new Point();
        }

        public Segment(Point p1, Point p2)
        {
            this.p1 = new Point(p1);
            this.p2 = new Point(p2);
        }

        public Segment(Segment segment)
            : this(segment.p1, segment.p2) { }
        #endregion


        public override string ToString() =>
            $"Segment[Point 1: {P1}, Point 2: {P2} - d: {Length}, Middle: {Middle}]";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 3);
            Point p2 = new Point(10, 2);
            Segment segment = new Segment(p1, p2);

            Console.WriteLine(segment);
            Console.ReadKey();
        }
    }
}

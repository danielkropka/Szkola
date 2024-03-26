using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApp
{
    class Triangle
    {
        double a, b, c;
        #region property
        public double A 
        {
            get => a;
            set
            {
                if (value < 1)
                    a = 1;
                a = value;
            }
                
        }

        public double B
        {
            get => b;
            set
            {
                if (value < 1)
                    b = 1;
                b = value;
            }

        }

        public double C
        {
            get => c;
            set
            {
                if (value < 1)
                    c = 1;
                c = value;
            }

        }
        #endregion
        #region constructors
        public Triangle() { A = 1; B = 1; C = 1; }
        public Triangle(double a) { A = a; B = a; C = a; }
        public Triangle(double a, double b) { A = a; B = b; C = a; }
        public Triangle(double  a, double b, double c) { A = a; B = b; C = c; }
        #endregion
        #region methods
        public double Perimeter() => A + B + C;
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        #endregion
        public override string ToString() => $"Triangle[A: {A}, B: {B}, C: {C} - Pole: {Area()}, Obwód: {Perimeter()}]";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(5);
            Triangle t3 = new Triangle(5, 2);
            Triangle t4 = new Triangle(12, 8, 7);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.ReadKey();
        }
    }
}

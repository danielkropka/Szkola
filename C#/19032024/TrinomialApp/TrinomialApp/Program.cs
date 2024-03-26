using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinomialApp
{
    class Trinomial
    {
        double a, b, c;

        #region properties
        public double A
        {
            get => a;
            set
            {
                if (value == 0)
                    return;
                a = value;
            }
        }

        public double B { get => b; set { b = value; } }
        public double C { get => c; set { c = value; } }
        #endregion
        #region constructors
        public Trinomial()
        {
            A = 1;
            B = 0;
            C = 0;
        }

        public Trinomial(double a) : this()
        {
            A = a;
            B = a;
            C = a;
        }

        public Trinomial(double a, double b, double c) : this()
        {
            A = a;
            B = b; 
            C = c;
        }
        #endregion
        #region methods
        public double GetDelta() => Math.Pow(B, 2) - (4 * A * C);
        public (int, double?, double?) GetSolutions()
        {
            double delta = GetDelta();
            if (delta > 0)
                return (2, -B - Math.Sqrt(delta) / 2 * A, -B + Math.Sqrt(delta) / 2 * A);
            else if (delta < 0)
                return (0, null, null);
            else return (1, -B / 2 * A, null);
        }

        public (double, double) GetApex() => (-B / 2 * A, -GetDelta() / 4 * A);
        #endregion

        public override string ToString()
        {
            (int solutions, double? x1, double? x2) = GetSolutions();
            return $"Trinomial[ A: {A}, B: {B}, C: {C} - Delta: {GetDelta()}, Rozwiązania: {solutions}, X1: {x1}, X2: {x2} - Wsp. wierzch.: W={GetApex()}]";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Trinomial t1 = new Trinomial();
            Trinomial t2 = new Trinomial(2);
            Trinomial t3 = new Trinomial(1, 3, 2);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.ReadKey();
        }
    }
}

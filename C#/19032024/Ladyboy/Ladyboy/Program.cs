using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladyboy
{
    class KCircle
    {
        string name;
        double r;

        public string Name 
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    return;
                name = value;
            } 
        }

        public double R
        {
            get => r;
            set
            {
                if (value <= 0)
                    return;
                r = value;
            }
        }

        public KCircle()
        {
            Name = "noname";
            R = 1;
        }
        public KCircle(double radius) : this() => R = radius;
        public KCircle(string name, double radius) : this()
        {
            Name = name;
            R = radius;
        }
                
        public double GetPermimeter() => 2 * Math.PI * R;
        public double GetArea() => Math.PI * Math.Pow(R, 2);

        public override string ToString() => $"KCircle[Nazwa: {Name}, Promień: {R} - Obwód: {GetPermimeter()}, Pole: {GetArea()}]";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KCircle c1 = new KCircle();
            KCircle c2 = new KCircle(0.5);
            KCircle c3 = new KCircle("O2", 15);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.ReadKey();
        }
    }
}

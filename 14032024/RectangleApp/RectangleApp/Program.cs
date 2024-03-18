using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Rectangle
    {
        private double a, b;
        public double A 
        {
            get => a;
            set 
            {
                if (value < 1)
                {
                    a = 1;
                    return;
                }
                a = value;
            }
        }
        public double B
        {
            get => b;
            set
            {
                if (value < 1)
                {
                    b = 1;
                    return;
                }
                b = value;
            }
        }
        public Rectangle() { a = 1; b = 1; }
        public Rectangle(double a) { A = a; B = a; }
        public Rectangle(double a, double b) { A = a; B = b; }

        private double GetCircuit() => 2 * a + 2 * b;
        private double GetArea() => a * b;

        public override string ToString()
        {
            return $"Rectangle[A: {a}, B: {b} - Pole: {GetArea()}, Obwód: {GetCircuit()}]";
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Rectangle rect1 = new Rectangle(5);
            Rectangle rect2 = new Rectangle(5, 10);

            Console.WriteLine(rect);
            Console.WriteLine(rect1);
            Console.WriteLine(rect2);
            Console.ReadKey();
        }
    }
}

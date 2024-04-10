using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrogen
{
    class Train
    {
        Carriage c1,
            c2;

        public Carriage C1 => c1;
        public Carriage C2 => c2;

        public double ValueOfCarriages
        {
            get => c1.Money + c2.Money;
        }
        public double Passangers
        {
            get => c1.Passangers + c2.Passangers;
        }

        public Train()
        {
            c1 = new Carriage();
            c2 = new Carriage();
        }

        public Train(Carriage c1, Carriage c2)
            : this()
        {
            this.c1 = new Carriage(c1);
            this.c2 = new Carriage(c2);
        }

        public Train(Train t)
            : this(t.c1, t.c2) { }

        public override string ToString() =>
            $"Train[Pasażerowie: {Passangers}, Hajs: {ValueOfCarriages} PLN\n\t{C1}\n\t{C2}\n]";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carriage c1 = new Carriage();
            Carriage c2 = new Carriage();
            Carriage c3 = new Carriage("1", 34.30, 10);
            Carriage c4 = new Carriage("2", 27.90, 25);
            Train t = new Train();
            Train t1 = new Train(c1, c2);
            Train t2 = new Train(c3, c4);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(t);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.ReadKey();
        }
    }
}

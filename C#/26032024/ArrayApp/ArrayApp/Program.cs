using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    delegate int ArrayDelegate(int wanted);

    class MyArray
    {
        int[] t;
        public int[] T => t;

        public MyArray(int n = 100) => t = new int[n];

        public MyArray(ArrayDelegate init, int n = 100)
            : this(n)
        {
            for (int i = 0; i < T.Length; i++)
                T[i] = init(i);
        }

        public override string ToString() => $"MyArray[{string.Join(", ", T)}]";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MyArray a = new MyArray(100);
            MyArray a1 = new MyArray((i) => rnd.Next(i, 100 + 1), 100);

            Console.WriteLine(a1);
            Console.ReadKey();
        }
    }
}

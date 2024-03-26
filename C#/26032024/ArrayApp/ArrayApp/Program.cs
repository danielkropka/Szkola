using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class MyArray
    {
        int n;
        int[] t;

        public int N
        {
            get => n;
            set
            {
                if (n == value || value < 0)
                    return;
                n = value;
            }
        }

        public MyArray()
        {
            N = 0;
            t = new int[N];
        }

        public MyArray(int n)
            : this()
        {
            N = n;
            t = new int[N];
        }

        public override string ToString() => $"MyArray[N: {N}, {string.Join(", ", t)}]";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(5);

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}

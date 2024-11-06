using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    public class ArrayClass
    {
        private float[] t;
        public float[] T => t;
        public float Max => t.Max();
        Random rand = new Random();

        public ArrayClass(int n = 100) => t = new float[n];

        public void Init(int from = 0, int to = 1000)
        {
            for (int i = 0; i < t.Length; i++)
                t[i] = rand.Next(from, to + 1);
        }

        public void Show()
        {
            for (int i = 0; i < t.Length; i++)
                Console.WriteLine($"{i}:{t[i]}");
        }

        public void DivideByMax()
        {
            for (int i = 0; i < t.Length; i++)
                t[i] /= Max;
        }

        public override string ToString() => $"{string.Join(", ", T)}";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayClass arrayClass = new ArrayClass();
            arrayClass.Init();
            Console.WriteLine(arrayClass);
            arrayClass.DivideByMax();
            Console.WriteLine();
            Console.WriteLine(arrayClass);
            Console.ReadKey();
        }
    }
}

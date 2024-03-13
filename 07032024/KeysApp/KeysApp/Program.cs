using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int i = 0;
            bool stop = false;
            do 
            {
                Console.Write(i++);
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape: 
                            stop = true; 
                        break;
                    }
                }
            } while (!stop);
            Console.ReadKey();
        }
    }
}

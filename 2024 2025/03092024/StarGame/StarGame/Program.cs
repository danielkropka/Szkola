using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StarGame.Classes;

namespace StarGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(50);
            game.ShowStars();
            game.Listener();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame.Classes
{
    public class Game
    {
        private Star[] stars = new Star[100];
        private int starsCount;
        private Random rand = new Random();
        private ConsoleKeyInfo pressedKey;

        private int GetRandom(int minValue, int maxValue) => rand.Next(minValue, maxValue + 1);

        public void Listener()
        {
            do
            {
                pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.N:
                        AddStar();
                        ShowStars();
                        break;
                }
            } while (pressedKey.Key != ConsoleKey.Escape);
        }

        public void ShowStars()
        {
            for (int i = 0; i < starsCount; i++)
            {
                Console.SetCursorPosition(stars[i].X, stars[i].Y);
                Console.Write("*");
            }
        }

        public void AddStar()
        {
            if (starsCount + 1 >= stars.Length)
                return;
            stars[starsCount++] = new Star(GetRandom(0, 20), GetRandom(0, 20));
        }

        public Game(int n = 100)
        {
            stars = new Star[n];
            starsCount = 0;
            AddStar();
        }
    }
}

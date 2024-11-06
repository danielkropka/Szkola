using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeApp.Classes
{
    internal class Game
    {
        private Cube[] cubes;
        public Cube[] Cubes => cubes;
        Random rnd = new Random();

        public Game()
        {
            int givenNumber;
            do
            {
                Console.WriteLine("Ile kostek chcesz rzucić?(3 - 10)");
                givenNumber = int.Parse(Console.ReadLine());
            } while (givenNumber < 3 || givenNumber > 10);

            cubes = new Cube[givenNumber];

            for (int i = 0; i < givenNumber; i++)
            {
                cubes[i] = new Cube(i + 1);
                cubes[i].NumberOfStitches = rnd.Next(1, 7);
            }

            for (int i = 0; i < cubes.Length; i++)
            {
                Console.WriteLine(cubes[i]);
            }

            int result = 0,
                k;
            for (int i = 1; i < 7; i++)
            {
                k = HowManyExceptions(i);
                result += k > 1 ? k * i : 0;
            }

            Console.WriteLine($"Liczba uzyskanych punktów: {result}");
        }

        int HowManyExceptions(int number)
        {
            int result = 0;
            foreach (var cube in cubes)
                if (cube.NumberOfStitches == number)
                    result++;
            return result;
        }
    }
}

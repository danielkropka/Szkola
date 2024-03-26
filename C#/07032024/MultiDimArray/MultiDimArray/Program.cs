using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimArray
{
    internal class Program
    {
        static void InitArray(char[,] t, char c) 
        {
            Random rnd = new Random();
            for (int i = 0; i < t.GetLength(0); i++)
                for (int j = 0; j < t.GetLength(1); j++)
                    t[i, j] = rnd.Next(0, 2) == 0 ? c : ' ';
        }


        static void Main(string[] args)
        {
            string[][] personalData = new string[2][];

            for (int i = 0; i < personalData.Length; i++)
            {
                string firstName, secondName, surname;
                Console.WriteLine("Podaj imię: ");
                firstName = Console.ReadLine();
                Console.WriteLine("Podaj 2 imię: ");
                secondName = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko: ");
                surname = Console.ReadLine();

                if(secondName.Length != 0)
                {
                    personalData[i] = new string[3];
                    personalData[i][0] = firstName;
                    personalData[i][1] = surname;
                    personalData[i][2] = secondName;
                } else
                {
                    personalData[i] = new string[2];
                    personalData[i][0] = firstName;
                    personalData[i][1] = surname;
                }

            }

            Console.WriteLine("\n");

            for (int i = 0; i < personalData.GetLength(0); i++) 
                for (int j = 0; j < personalData[i].Length; j++)
                {
                    Console.Write(j == 0 ? "Imię: " : j == 1 ? "Nazwisko: " : "Drugie imię: ");
                    Console.Write(personalData[i][j]);
                    Console.WriteLine("\n");
                }

            #region old
            /*char[,] chars = new char[20, 50];

            InitArray(chars, '*');
            
            for (int i = 0; i < chars.GetLength(0); i++) 
                for(int j = 0; j < chars.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(chars[i, j]);
                }*/
            /*            int[,] t = new int[10, 10];

                        for (int i = 0; i < 10; i++)
                            for (int j = 0; j < 10; j++)
                                t[i, j] = (i + 1) * (j + 1);

                        Console.WriteLine("Podaj 1 liczbę: ");
                        int k = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj 2 liczbę: ");
                        int l = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{k} * {l} = {t[k - 1, l - 1]}");*/
            #endregion
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rats
{
    delegate void BMIDelegate(double bmi);
    internal class Program
    {
        static void ShowBMI(double bmi) => Console.WriteLine($"BMI: {bmi}");

        static void ShowFormatBMI(double bmi)
        {
            /*if (bmi <= 20) 
                Console.WriteLine($"{bmi} - niedowaga");
            else if (bmi > 24)
                Console.WriteLine($"{bmi} - nadwaga");
            else
                Console.WriteLine($"{bmi} - norma");*/

            Console.WriteLine(bmi <= 20 ? $"{bmi} - niedowaga" : bmi > 24 ? $"{bmi} - nadwaga" : $"{bmi} - norma");
        }

        static double Validation(string label)
        {
            bool isParsed = true;
            double result;
            do
            {
                Console.WriteLine(label);
                if (double.TryParse(Console.ReadLine(), out result) && result > 0)
                    isParsed = false;
                else
                    Console.WriteLine("Podano błędne dane!");

            } while (isParsed);
            return result;
        }

        static void BMI(BMIDelegate showBMI)
        {
            double weight = Validation("Podaj wagę: ");
            double height = Validation("Podaj wzrost: ");

            showBMI(weight / (height * height));
        }
        static void Main(string[] args)
        {
            BMI(ShowBMI);
            Console.WriteLine();
            BMI(ShowFormatBMI);
            Console.ReadLine();
        }
    }
}

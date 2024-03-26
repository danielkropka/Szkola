using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiApp
{
    class BMI
    {
        private double weight, height;

        public BMI() { weight = 1; height = 1; }
        public BMI(double height, double weight) { this.height = height; this.weight = weight; }

/*        public void SetWeight(double weight) => this.weight = weight;
        public void SetHeight(double height) => this.height = height;*/

        public double Get()
        {
            return weight / (height * height);
        }
        public override string ToString()
        {
            return $"BMI[ Waga: {weight}, Wzrost: {height} - BMI: {Get()}]";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BMI bmi = new BMI();
            BMI klucha = new BMI(91, 1.81);

            /*            klucha.SetWeight(98);
                        klucha.SetHeight(1.80);*/

            Console.WriteLine(bmi);
            Console.WriteLine(klucha);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupleApp
{
    class Person
    {
        string fName, lName;
        int age;

        #region property
        public string FName 
        {
            get => fName; 
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                fName = value;
            }
        }
        public string LName
        {
            get => lName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                lName = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value <= 0)
                    return;
                age = value;
            }
        }
        #endregion
        #region constructor
        public Person()
        {
            FName = "noname";
            LName = "noname";
            Age = 1;
        }
        public Person(string fName, string lName) : this()
        {
            FName = fName;
            LName = lName;
        }
        public Person(string fName, string lName, int age) : this()
        {
            FName = fName;
            LName = lName;
            Age = age;
        }
        #endregion

        public override string ToString() => $"Person[{FName} {LName} - {Age}]";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person("Krzysiek", "Antoniuk", 18);
            Person p4 = new Person("Zosia", "Nadgórska", 19);

            Couple c1 = new Couple();
            Couple c2 = new Couple(p1, p2);
            Couple c3 = new Couple(p3, p4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.ReadKey();
        }
    }
}

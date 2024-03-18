using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        string name, surname;
        int age;

        public string Name 
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    return;
                name = value;
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    return;
                surname = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (age < 1)
                    return;
                age = value;
            }
        }

        public Person()
        {
            name = "noname";
            surname = "noname";
            age = 1;
        }

        public Person(int age) : this() => Age = age;

        public Person(string name, string surname, int age) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        string Reverse(string value)
        {
            char[] tmp = value.ToCharArray();
            string reversed = string.Empty;
            for (int i = tmp.Length - 1; i > -1; i--)
                reversed += tmp[i];
            reversed = reversed.ToLower();
            return reversed;
        }

        public void Show(int mode = 0)
        {
            switch (mode) 
            {
                case 0:
                    Console.WriteLine(this);
                    break;
                case 1:
                    Console.WriteLine($"Imię: {Name}, Nazwisko: {Surname}");
                    break;
                case 2:
                    Console.WriteLine($"Imię: {Name}, Nazwisko: {Surname} - Wiek: {Age}");
                    break;
                case 3:
                    Console.WriteLine($"Imię: {Reverse(Name)}, Nazwisko: {Reverse(Surname)}");
                    break;
                default:
                    Console.WriteLine(this);
                    break;
            }
        }

        public void ShowNameAndSurname(bool isReversed = false)
        {
            Console.WriteLine($"Imię: {(isReversed ? Reverse(Name) : Name)}, Nazwisko: {(isReversed ? Reverse(Surname) : Surname)}");
        }

        public override string ToString() => $"Person[Imię: {Name}, Nazwisko: {Surname} - Wiek: {Age}]";

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person(18);
            Person person2 = new Person("Daniel", "Warpechowski", 18);

            person2.ShowNameAndSurname();
            person2.ShowNameAndSurname(true);
            Console.WriteLine(person);
            Console.WriteLine(person1);
            Console.WriteLine(person2);

            Console.ReadKey();
        }
    }
}

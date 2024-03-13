using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    public class Person
    {
        public string FirstName, LastName;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Daniel";
            person.LastName = "Warpechowski";


            Console.ReadKey();
        }
    }
}

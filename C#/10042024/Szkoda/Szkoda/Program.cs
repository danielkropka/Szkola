using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szkoda.Classes;

namespace Szkoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Daniel", 500.2);
            Teacher teacher = new Teacher("Maciej", 3400.90, "Programowanie");
            Developer developer = new Developer("Krzysztof", 5000.3, "Frontend");
            Console.WriteLine(employee);
            Console.WriteLine(teacher);
            Console.WriteLine(developer);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolGroupApp
{
    class SchoolGroup
    {
        private string Name, Profile;
        private int AmountOfStudents;

        public void AddStudents(int count = 1)
        {
            AmountOfStudents += count;
        }

        public void RemoveStudents(int count = 1)
        {
            AmountOfStudents -= count;
        }

        public void SetGroup(string name, string profile, int amountOfStudents)
        {
            Name = name;
            Profile = profile;
            AmountOfStudents = amountOfStudents;
        }

        public override string ToString()
        {
            return $"SchoolGroup {Name}, {Profile}, {AmountOfStudents}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolGroup schoolGroup = new SchoolGroup();
            schoolGroup.SetGroup("4TPI", "Programista", 14);
            schoolGroup.AddStudents(2);
            schoolGroup.RemoveStudents(1);

            Console.WriteLine(schoolGroup);

            Console.ReadKey();
        }
    }
}

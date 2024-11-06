using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassApp.Classes
{
    public class Class
    {
        public string Name { get; set; }
        public string Profile { get; set; }
        public string MainTeacher { get; set; }
        public int NumberOfStudents { get; set; }

        public Class(string name, string profile, string mainTeacher, int numberOfStudnets)
        {
            Name = name;
            Profile = profile;
            MainTeacher = mainTeacher;
            NumberOfStudents = numberOfStudnets;
        }

        public override string ToString() => $"{Name} | {NumberOfStudents}";
    }
}

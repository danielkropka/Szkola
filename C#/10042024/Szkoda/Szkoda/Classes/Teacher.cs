using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkoda.Classes
{
    internal class Teacher : Employee
    {
        #region field
        string subject;
        #endregion

        #region property
        public string Subject
        {
            get => subject;
            set
            {
                if (subject == value || string.IsNullOrWhiteSpace(value))
                    return;
                subject = value;
            }
        }
        #endregion

        #region constructor
        public Teacher() => Subject = "noname";

        public Teacher(string subject)
            : this() => Subject = subject;

        public Teacher(string name, double salary, string subject)
            : base(name, salary)
        {
            Subject = "noname";
            Subject = subject;
        }
        #endregion

        public override string ToString() =>
            $"Teacher[Subject: {Subject}, Name: {Name}, Salary: {Salary}]";
    }
}

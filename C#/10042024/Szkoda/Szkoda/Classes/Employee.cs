using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkoda.Classes
{
    internal class Employee
    {
        #region field
        protected string name;
        protected double salary;
        #endregion

        #region property
        public string Name
        {
            get => name;
            set
            {
                if (name == value || string.IsNullOrWhiteSpace(value))
                    return;
                name = value;
            }
        }

        public double Salary
        {
            get => salary;
            set
            {
                if (salary == value || value <= 0)
                    return;
                salary = value;
            }
        }
        #endregion
        #region constructor
        public Employee()
        {
            Name = "noname";
            Salary = 0;
        }

        public Employee(string name, double salary)
            : this()
        {
            Name = name;
            Salary = salary;
        }

        #endregion
        public override string ToString() => $"Employee[Name: {Name}, Salary: {Salary}]";
    }
}

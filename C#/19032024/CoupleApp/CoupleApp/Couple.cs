using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupleApp
{
    class Couple
    {
        Person p1;
        Person p2;

        public Person P1 => p1;
        public Person P2 => p2;

        public Couple()
        {
            p1 = new Person();
            p2 = new Person();
        }

        public Couple(Person p1, Person p2) : this()
        {
            this.p1 = new Person(p1.FName, p1.LName, p1.Age);
            this.p2 = new Person(p2.FName, p2.LName, p2.Age);
        }

        public override string ToString() => $"Couple[{P1} - {P2}]";
    }
}

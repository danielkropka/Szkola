using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Car : Vehicle
    {
        #region fields
        string make;
        #endregion
        #region property
        public string Make
        {
            get => make;
            set
            {
                if (value == make || string.IsNullOrWhiteSpace(value))
                    return;
                make = value;
            }
        }
        #endregion
        #region constructor
        public Car() => Make = "noname";

        public Car(string make)
            : this() => Make = make;

        public Car(string make, double speed, double vmax)
            : base(speed, vmax) => Make = make;
        #endregion

        #region override
        public override string ToString() => $"Car[Marka: {Make}\n\t{base.ToString()}\n]";
        #endregion
    }
}

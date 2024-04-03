using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentApp
{
    class Apartment
    {
        int number;
        readonly Room r1,
            r2,
            r3;

        public Room R1 => r1;
        public Room R2 => r2;
        public Room R3 => r3;

        #region property
        public int Number
        {
            get => number;
            set
            {
                if (value < 0 || value == number)
                    return;
                number = value;
            }
        }
        public double Area => r1.Area + r2.Area + r3.Area;
        #endregion
        #region constructor
        public Apartment()
        {
            Number = 0;
            r1 = new Room();
            r2 = new Room();
            r3 = new Room();
        }

        public Apartment(int number, Room r1, Room r2, Room r3)
            : this()
        {
            Number = number;
            this.r1 = new Room(r1);
            this.r2 = new Room(r2);
            this.r3 = new Room(r3);
        }

        public Apartment(Apartment apartment)
            : this(apartment.Number, apartment.r1, apartment.r2, apartment.r3) { }
        #endregion

        public override string ToString() =>
            $"Apartment[Number: {Number}, Area: {Area} - Room 1: {r1}, Room 2: {r2}, Room 3: {r3}]";
    }
}

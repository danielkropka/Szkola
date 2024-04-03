using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomApp
{
    internal class ClassRoom
    {
        string name;
        int maxStudents;

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

        public int MaxStudents
        {
            get => maxStudents;
            set
            {
                if (maxStudents == value || value <= 0)
                    return;
                maxStudents = value;
            }
        }

        public ClassRoom()
        {
            Name = "noname";
            MaxStudents = 1;
        }

        public ClassRoom(string name, int max)
            : this()
        {
            Name = name;
            MaxStudents = max;
        }

        public ClassRoom(ClassRoom c)
            : this(c.name, c.maxStudents) { }

        public override string ToString() =>
            $"ClassRoom[Nazwa: {Name}, maksymalna ilość miejsc: {MaxStudents}]";
    }
}

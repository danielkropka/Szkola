using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomApp
{
    class Floor
    {
        string name;
        ClassRoom cr1,
            cr2,
            cr3;
        public int MaxCount => cr1.MaxStudents + cr2.MaxStudents + cr3.MaxStudents;

        public ClassRoom CR1 => cr1;
        public ClassRoom CR2 => cr2;
        public ClassRoom CR3 => cr3;

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

        public Floor()
        {
            Name = "noname";
            cr1 = new ClassRoom();
            cr2 = new ClassRoom();
            cr3 = new ClassRoom();
        }

        public Floor(string name)
            : this() => Name = name;

        public Floor(string name, ClassRoom cr1, ClassRoom cr2, ClassRoom cr3)
            : this(name)
        {
            this.cr1 = new ClassRoom(cr1);
            this.cr2 = new ClassRoom(cr2);
            this.cr3 = new ClassRoom(cr3);
        }

        public Floor(Floor f)
            : this(f.name, f.cr1, f.cr2, f.cr3) { }

        public override string ToString() =>
            $"Floor[Nazwa: {Name}, Max ilość uczniów: {MaxCount}\n\t{CR1}\n\t{CR2}\n\t{CR3}\n]";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom r1 = new ClassRoom("18", 30);
            ClassRoom r2 = new ClassRoom("1C", 15);
            ClassRoom r3 = new ClassRoom("3B", 28);

            Floor f1 = new Floor("Piętro 1", r1, r2, r3);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(f1);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkodaV2.Classes
{
    internal class Package
    {
        #region field
        protected string name;
        protected double v;
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

        public double V
        {
            get => v;
            set
            {
                if (v == value || value <= 0)
                    return;
                v = value;
            }
        }
        #endregion

        #region constructor
        public Package()
        {
            Name = "noname";
            V = 1;
        }

        public Package(string name, double v)
            : this()
        {
            Name = name;
            V = v;
        }
        #endregion

        public override string ToString() => $"Package[Name: {Name}, V: {V}]";
    }
}

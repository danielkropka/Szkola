using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkoda.Classes
{
    internal class Developer : Employee
    {
        #region field
        string profile;
        #endregion

        #region property
        public string Profile
        {
            get => profile;
            set
            {
                if (profile == value || string.IsNullOrWhiteSpace(value))
                    return;
                profile = value;
            }
        }
        #endregion
        #region constructor
        public Developer() => Profile = "Frontend";

        public Developer(string profile)
            : this() => Profile = profile;

        public Developer(string name, double salary, string profile)
            : base(name, salary)
        {
            Profile = "Frontend";
            Profile = profile;
        }
        #endregion

        public override string ToString() =>
            $"Developer[Profile: {Profile}\n\t{base.ToString()}\n]";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomsInheritedApp
{
    internal class Bathroom : Room
    {
        string options;

        public string Options
        {
            get => options;
            set
            {
                if (value == options || string.IsNullOrWhiteSpace(value))
                    return;
                options = value;
            }
        }

        public Bathroom()
        {
            Options = "ns";
        }

        public Bathroom(string options)
            : this() => Options = options;

        public Bathroom(string options, double surface, double height)
            : base(surface, height) => Options = options;

        public string ConvertOptions()
        {
            string result = string.Empty;
            if (Options.Contains("w"))
                result += "\n\tWanna";
            if (Options.Contains("n"))
                result += "\n\tNatrsyk";
            if (Options.Contains("s"))
                result += "\n\tSedes";
            if (Options.Contains("b"))
                result += "\n\tBidet";
            return result;
        }

        public override string ToString() =>
            $"Bathroom[\nOpcje: {ConvertOptions()}\n\n\t{base.ToString()}\n]";
    }
}

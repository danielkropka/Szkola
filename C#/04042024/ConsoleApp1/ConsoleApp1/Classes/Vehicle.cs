using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Vehicle
    {
        #region fields
        protected double v,
            vMax;
        #endregion
        #region property
        public double V
        {
            get => v;
            set
            {
                if (value == v || value < 0)
                    return;
                v = value;
            }
        }

        public double VMax
        {
            get => vMax;
            set
            {
                if (value <= 0 || value == vMax)
                    return;
                vMax = value;
            }
        }
        #endregion
        #region method
        public void Stop() => V = 0;

        public void Start(double speed = 10) => V = speed;

        #endregion
        #region constructor
        public Vehicle()
        {
            V = 0;
            VMax = 1;
        }

        public Vehicle(double speed, double vmax = 100)
            : this()
        {
            V = speed;
            VMax = vmax;
        }
        #endregion

        #region override
        public override string ToString() => $"Vehicle[Prędkość: {V}, Predkość maksymalna: {VMax}]";
        #endregion
    }
}

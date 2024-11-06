using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame.Classes
{
    public class Star
    {
        private int x,
            y,
            vx,
            vy;

        public int X
        {
            get => x;
            set
            {
                if (value < 0)
                    return;
                x = value;
            }
        }

        public int Y
        {
            get => y;
            set
            {
                if (value < 0)
                    return;
                y = value;
            }
        }

        public int Vx
        {
            get => vx;
            set
            {
                if (value == 0)
                    return;
                vx = value;
            }
        }

        public int Vy
        {
            get => vy;
            set
            {
                if (value == 0)
                    return;
                vy = value;
            }
        }

        public void Move()
        {
            x += vx;
            y += vy;
        }

        public Star()
        {
            Vx = 1;
            Vy = 1;
            X = 0;
            Y = 0;
        }

        public Star(int x, int y)
            : this()
        {
            X = x;
            Y = y;
        }

        public Star(int x, int y, int vx, int vy)
            : this()
        {
            X = x;
            Y = y;
            Vx = vx;
            Vy = vy;
        }

        public Star(Star star)
            : this()
        {
            X = star.X;
            Y = star.Y;
            Vx = star.Vx;
            Vy = star.Vy;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class CCircle
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public const int radius = 50;

        public bool IsSelected { get; set; } = false;
        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool In(int x, int y)
        {
            int distance = (x - this.x) * (x - this.x) + (y - this.y) * (y - this.y);

            if (distance < radius * radius)
            { 
                return true;
            }
            return false;
        }
        public void Drow(Graphics g)
        {
            if (IsSelected)
            {
                g.DrawEllipse(
                    Pens.Blue,
                    x - CCircle.radius,
                    y - CCircle.radius,
                    CCircle.radius * 2,
                    CCircle.radius * 2
                );
            }
            else
            {
                g.DrawEllipse(
                    Pens.Black,
                    x - CCircle.radius,
                    y - CCircle.radius,
                    CCircle.radius * 2,
                    CCircle.radius * 2
                );
            }
        }
    }
}

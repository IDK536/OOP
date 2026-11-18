using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class CCircle: CShape
    {

        public int radius = 50;

        public CCircle(int x, int y)
        {
            this.point.X = x;
            this.point.Y = y;
        }

        public override bool In(int x, int y)
        {
            int distance = (x - this.point.X) * (x - this.point.X) + (y - this.point.Y) * (y - this.point.Y);

            if (distance < radius * radius)
            { 
                return true;
            }
            return false;
        }
        public override void Draw(Graphics g)
        {
            if (IsSelected)
            {
                g.DrawEllipse(
                    Pens.Blue,
                    point.X - CCircle.radius,
                    point.Y -CCircle.radius,
                    CCircle.radius * 2,
                    CCircle.radius * 2
                );
            }
            else
            {
                g.DrawEllipse(
                    Pens.Black,
                    point.X - CCircle.radius,
                    point.Y - CCircle.radius,
                    CCircle.radius * 2,
                    CCircle.radius * 2
                );
            }
        }
    }
}

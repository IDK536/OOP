using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class CSquare: CShape
    {
        private int width = 100;

        public CSquare(int x, int y)
        {
            this.point.X = x;
            this.point.Y = y;
        }

        public override bool In(int x, int y)
        {
            if (x >= this.point.X - width / 2 && x <= this.point.X + width / 2 &&
                y >= this.point.Y - width / 2 && y <= this.point.Y + width / 2)
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
                    point.Y - CCircle.radius,
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
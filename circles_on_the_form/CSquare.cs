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
                g.DrawRectangle(
                    Pens.Blue,
                    point.X,
                    point.Y,
                    width,
                    width
                );
            }
            else
            {
                g.DrawRectangle(
                    Pens.Black,
                    point.X,
                    point.Y,
                    width,
                    width
                );
            }
        }
    }
}
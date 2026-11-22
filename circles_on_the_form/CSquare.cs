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
        private Point[] points = new Point[4];

        public CSquare(int x, int y)
        {
            this.point.X = x;
            this.point.Y = y;
            UpdatePoints();
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

        public override Rectangle GetBounds()
        {
            int left = point.X - width / 2;
            int top = point.Y - width / 2;
            Rectangle bounds = new Rectangle(left, top, width, width);

            return bounds;
        }

        public override void Draw(Graphics g)
        {
            if (IsSelected)
            {
                g.DrawPolygon(
                    Pens.Blue,
                    points
                );
            }
            else
            {
                g.DrawPolygon(
                    new Pen(color),
                    points
                );
            }
        }

        public override void Scale(int scale)
        {
            width += scale;
            UpdatePoints();
        }

        public override void Move(int deltaX, int deltaY)
        {
            point.X += deltaX;
            point.Y += deltaY;
            UpdatePoints();
        }


        private void UpdatePoints()
        {
            points[0] = new Point(this.point.X - width / 2, this.point.Y - width / 2);
            points[1] = new Point(this.point.X + width / 2, this.point.Y - width / 2);
            points[2] = new Point(this.point.X + width / 2, this.point.Y + width / 2);
            points[3] = new Point(this.point.X - width / 2, this.point.Y + width / 2);

        }

    }
}
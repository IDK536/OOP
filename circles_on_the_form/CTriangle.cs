using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class CTriangle: CShape
    {
        private int radius = 40;
        Point[] points = new Point[3];

        public CTriangle(int x, int y) 
        {
            point.X = x;
            point.Y = y;
            UpdatePoints();
        }

        public override bool In(int x, int y)
        {
            PointF p = new PointF(x, y);
            double a = Cross(points[0], points[1], p);
            double b = Cross(points[1], points[2], p);
            double c = Cross(points[2], points[0], p);

            bool negative = a < 0 || b < 0 || c < 0;
            bool positive = a > 0 || b > 0 || c > 0;

            return !(negative && positive);
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
                    Pens.Black,
                    points
                );
            }
        }

        public override void Scale(int scale)
        {
            radius += scale;
        }



        private double Cross(PointF a, PointF b, PointF p)
        {
            return (b.X - a.X) * (p.Y - a.Y)
                 - (b.Y - a.Y) * (p.X - a.X);
        }

        private void UpdatePoints()
        {
            points[0] = new Point(point.X, point.Y - radius);
            points[1] = new Point(point.X - radius, point.Y + radius / 2);
            points[2] = new Point(point.X + radius, point.Y + radius / 2);
        }
    }
}

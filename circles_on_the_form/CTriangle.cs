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
        PointF[] points;

        public override bool In(int x, int y)
        {
            double a = Cross(t[0], t[1], p);
            double b = Cross(t[1], t[2], p);
            double c = Cross(t[2], t[0], p);

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



        private double Cross(Point a, Point b, Point p)
        {
            return (b.X - a.X) * (p.Y - a.Y)
                 - (b.Y - a.Y) * (p.X - a.X);
        }

        private PointF[] GetPoints()
        {
            PointF[] points = new PointF[3];
            points[0] = new PointF(point.X, point.Y - radius);
            points[1] = new PointF(point.X - radius, point.Y + radius / 2);
            points[2] = new PointF(point.X + radius, int.Y + radius / 2);

            return points;
        }
    }
}

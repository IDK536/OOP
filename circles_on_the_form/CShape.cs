using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    abstract class CShape
    {
        protected Point point;
        public Color color { get;  set; }

        public bool IsSelected { get; set; } = false;

        abstract public bool In(int x, int y);
        abstract public void Draw(Graphics g);
        public void Move(int deltaX, int deltaY)
        {
            point.X += deltaX;
            point.Y += deltaY;
        }
        abstract public void Scale(int scale);
    }
}

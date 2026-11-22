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
        public Color color { get;  set; } = Color.Black;

        public bool IsSelected { get; set; } = false;

        abstract public bool In(int x, int y);
        abstract public void Draw(Graphics g);
        abstract public void Move(int deltaX, int deltaY);
        abstract public void Scale(int scale);
    }
}

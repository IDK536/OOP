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

        public bool InWindow(int bottomBorder, int rightBorder)
        {
            Rectangle shapeBounds = GetBounds();
            if (shapeBounds.Width > 0 && shapeBounds.Height > 0 &&
                shapeBounds.Left >= 0 && shapeBounds.Right <= rightBorder &&
                shapeBounds.Top >= 0 && shapeBounds.Bottom <= bottomBorder)
            {
                return true;
            }
            return false;
        }

        abstract public Rectangle GetBounds();

        abstract public bool In(int x, int y);

        abstract public void Draw(Graphics g);
        abstract public void Move(int deltaX, int deltaY);
        abstract public void Scale(int scale);
    }
}

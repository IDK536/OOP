using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    abstract class CShape
    {
        protected int x;
        protected int y;

        public bool IsSelected { get; set; } = false;

        abstract public bool In(int x, int y);
        abstract public void Drow(Graphics g);
    }
}

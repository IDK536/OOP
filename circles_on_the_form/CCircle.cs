using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class CCircle
    {
        public int x { get; private set; }
        public int y { get; private set;}
        const int radius = 15;

        public bool IsSelected { get; set; } = false;

        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool In(int x, int y)
        {
            int distance = (x - this.x) * (x - this.x) + (y - this.y) * (y - this.y);

            if (distance < radius * radius)
            {
                IsSelected = true;
                return true;
            }
            return false;
        }        
    }
}

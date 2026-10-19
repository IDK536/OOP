using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class Storage
    {
        private List <CCircle> circles;

        void Add(CCircle circle)
        {
            circles.Add(circle);
        }

        public void Remove(CCircle circle)
        {
            circles.Remove(circle);
        }

        public CCircle Get(int key) 
        {
            return circles[key];
        }

        public void Select(int x, int y, bool isCtrl)
        {
            if (isCtrl)
            {
                foreach (CCircle circle in circles)
                {
                    if (circle.In(x, y))
                    {
                        circle.IsSelected = true;
                        break;
                    }
                }
            }
            else 
            {
                foreach (CCircle circle in circles)
                {
                    if (circle.In(x, y))
                    {
                        circle.IsSelected = true;
                    }
                    else
                    {
                        circle.IsSelected = false;
                    }
                }
            }
        }

        public void DeleteSelected()
        {
            foreach (CCircle circle in circles)
            {
            if (circle.IsSelected)
                Remove(circle);
            }
        }

        
    }
}

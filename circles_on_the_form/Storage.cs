using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class Storage
    {
        private List<CCircle> circles = new List<CCircle>();

        public void Add(CCircle circle)
        {
            circles.Add(circle);
        }

        public int GetLength()
        {
            return circles.Count;
        }

        public void Remove(CCircle circle)
        {
            circles.Remove(circle);
            circles.RemoveAll(t => t.IsSelected);
        }

        public CCircle Get(int key) 
        {
            return circles[key];
        }

        public void Select(int x, int y, bool isCtrl)
        {
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

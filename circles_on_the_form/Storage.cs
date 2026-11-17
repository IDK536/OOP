using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class Storage
    {
        private List<CShape> shapes = new List<CShape>();

        public void Add(CShape shape)
        {
            shapes.Add(shape);
        }

        public int GetLength()
        {
            return shapes.Count;
        }

        public void Remove(CShape shape)
        {
            shapes.Remove(shape);
        }

        public CShape Get(int key) 
        {
            return shapes[key];
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class DrawCommand: Command
    {
        private List<CShape> shapes;

        private List<CShape> selections;

        public DrawCommand(List<CShape> shapes)
        {
            this.shapes = shapes;
        }

        public override void Execute(List<CShape> shapes)
        {
            selections = new List<CShape>(shapes);
            for (int i = 0; i < shapes.Count; i++)
            {
                this.shapes.Add(shapes[i]);
            }
        }

        public void Execute(CShape shape)
        {
            selections = new List<CShape> { shape };
            this.shapes.Add(shape);
        }

        public override void UnExecute()
        {
            for (int i = 0; i < selections.Count; i++)
            {
                this.shapes.Remove(selections[i]);
            }
        }

        public override Command Clone()
        {
            return new DrawCommand(shapes);
        }
    }
}

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

        private CShape selection;

        public DrawCommand(List<CShape> shapes)
        {
            this.shapes = shapes;
        }

        public override void Execute(CShape shape)
        {
            selection = shape;

            shapes.Add(shape);
        }

        public override void UnExecute()
        {
            shapes.Remove(selection);
        }

        public override Command Clone()
        {
            return new DrawCommand(shapes);
        }
    }
}

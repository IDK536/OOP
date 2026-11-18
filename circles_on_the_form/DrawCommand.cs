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
        private List<CShape > selections;
        private DeleteCommand delete;

        public DrawCommand(List<CShape> shapes)
        {
            this.shapes = shapes;
        }

        public override void Execute(List<CShape> shapes)
        {
            selections = shapes;
            for (int i = 0; i < shapes.Count; i++)
            {
                this.shapes.Add(shapes[i]);
            }
        }

        public override void UnExecute()
        {
            //shapes.RemoveAll()
        }
    }
}

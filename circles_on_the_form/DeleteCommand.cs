using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class DeleteCommand: Command
    {
        private List<CShape> shapes;

        private CShape selection;
        private int index;

        public DeleteCommand(List<CShape> shapes)
        {
            this.shapes = shapes;
        }

        public override void Execute(CShape shape)
        {
            selection = shape;
            index = shapes.IndexOf(selection);

            if (index != -1)
            {
                shapes.Remove(shape);
            }
        }

        public override void UnExecute()
        {
            if (index != -1)
            {
                shapes.Insert(index, selection);
            }
        } 
    }
}

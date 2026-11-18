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
        private List<CShape> selections;

        public DeleteCommand(List<CShape> shapes)
        {
            this.shapes = shapes;
        }

        public override void Execute(List<CShape> shapes)
        {
            selections = shapes;
            this.shapes.RemoveAll(shape => shape.IsSelected);
        }

        public override void UnExecute()
        {
            for (int i = 0; i < selections.Count; i++) {
                shapes.Add(selections[i]);
            }
        }

        public override Command Clone()
        {
            return new DeleteCommand(shapes);
        }


    }
}

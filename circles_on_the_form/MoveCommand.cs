using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class MoveCommand:Command
    {
        private int deltaX;
        private int deltaY;

        private List<CShape> selections;
        public MoveCommand(int deltaX, int deltaY)
        {
            this.deltaX = deltaX;
            this.deltaY = deltaY;
        }

        public override void Execute(List<CShape> shapes)
        {
            selections = shapes;

            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Move(deltaX, deltaY);
            }
        }

        public override void UnExecute()
        {
            for (int i = 0; i < selections.Count; i++)
            {
                selections[i].Move(-deltaX, -deltaY);

            }
        }

        public override Command Clone()
        {
            return new MoveCommand(deltaX, deltaY);
        }
    }
}

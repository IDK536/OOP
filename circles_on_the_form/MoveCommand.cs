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

        private CShape selection;
        public MoveCommand(int deltaX, int deltaY)
        {
            this.deltaX = deltaX;
            this.deltaY = deltaY;
        }

        public override void Execute(CShape shape)
        {
            selection = shape;

            shape.Move(deltaX, deltaY);
        }

        public override void UnExecute()
        {
            selection.Move(-deltaX, -deltaY);
        }
    }
}

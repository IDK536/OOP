using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class SetColorCommand: Command
    {
        private Color color;
        private Color prevColor;
        private CShape selection;

        public SetColorCommand(Color color)
        {
            this.color = color;
        }

        public override void Execute(CShape shape)
        {
            selection = shape;
            prevColor = shape.color;

            shape.color = color;
        }

        public override void UnExecute()
        {
            selection.color = prevColor;
        }

        public override Command Clone()
        {
            return new SetColorCommand(color);
        }

    }
}

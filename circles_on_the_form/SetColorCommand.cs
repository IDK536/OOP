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
        private List<Color> prevColors;
        private List<CShape> selections;

        public SetColorCommand(Color color)
        {
            this.color = color;
        }

        public override void Execute(List<CShape> shapes)
        {
            selections = shapes;
            for (int i = 0; i < shapes.Count; i++)
            {
                prevColors[i] = shapes[i].color;
                shapes[i].color = color;
            }
        }

        public override void UnExecute()
        {
            for (int i = 0; i < selections.Count; i++)
            {
                selections[i].color = prevColors[i];
            }
        }

        public override Command Clone()
        {
            return new SetColorCommand(color);
        }

    }
}

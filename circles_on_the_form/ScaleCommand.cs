using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class ScaleCommand: Command
    {
        private int scale; 
            
        private List<CShape> selections;

        public ScaleCommand(int scale)
        {
            this.scale = scale;
        }

        public override void Execute(List<CShape> shapes)
        {
            selections = new List<CShape>(shapes);
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Scale(scale);
            }
        }

        public override void UnExecute()
        {
            for (int i = 0; i < selections.Count; i++)
            {
                selections[i].Scale(-scale);
            }
        }

        public override Command Clone()
        {
            return new ScaleCommand(scale);
        }

    }
}

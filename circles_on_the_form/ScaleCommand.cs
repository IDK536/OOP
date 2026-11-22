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
            
        private CShape selection;

        public ScaleCommand(int scale)
        {
            this.scale = scale;
        }

        public override void Execute(CShape shape)
        {
            selection = shape;

            shape.Scale(scale);
        }

        public override void UnExecute()
        {
            selection.Scale(-scale);
        }
    }
}

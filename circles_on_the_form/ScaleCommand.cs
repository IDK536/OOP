using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class ScaleCommand: Command
    {
        private float scale; 
        public ScaleCommand(float scale)
        {
            this.scale = scale;
        }

        public override void Execute(CShape shape)
        { 

        }

    }
}

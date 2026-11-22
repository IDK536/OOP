using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class SelectCommand: Command
    {
        private bool select;
        private CShape selection;

        public SelectCommand(bool select)
        {
            this.select = select;
        }

        public override void Execute(CShape shape)
        {
            selection = shape;

            shape.IsSelected = select;
        }

        public override void UnExecute()
        {
            selection.IsSelected = !select;
        }
    }
}

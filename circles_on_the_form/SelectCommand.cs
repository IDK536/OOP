using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class SelectCommand: Command
    {
        private List<CShape> selections;

        public override void Execute(List<CShape> shapes)
        {
            selections = new List<CShape>(shapes);

            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].IsSelected = true;
            }
        }

        public override void UnExecute()
        {
            for (int i = 0; i < selections.Count; i++)
            {
                selections[i].IsSelected = false;
            }
        }

        public override Command Clone()
        {
            return new SelectCommand();
        }
    }
}

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
        private List<CShape> selections;

        public SelectCommand(bool select)
        {
            this.select = select;
        }

        public override void Execute(List<CShape> shapes)
        {
            selections = new List<CShape>(shapes);

            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].IsSelected = select;
            }
        }

        public override void UnExecute()
        {
            for (int i = 0; i < selections.Count; i++)
            {
                selections[i].IsSelected = !select;
            }
        }

        public override Command Clone()
        {
            return new SelectCommand(select);
        }
    }
}

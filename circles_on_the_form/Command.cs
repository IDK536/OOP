using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    abstract class Command
    {
        abstract public void Execute(CShape shape);
        abstract public void UnExecute();
        abstract public Command Clone();
    }
}

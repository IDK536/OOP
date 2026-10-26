using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    internal class Numbers
    {
        private const int down = 0;
        private const int top = 100;

        public int A { 
             set 
            { 
                if ( down <= value && value <= B)
                {
                    A = value;
                }
            }
            get
            {
                return A;
            }
        }
        public int B
        {
            set
            {
                if (A <= value && value <= C)
                {
                    C = value;
                }
            }
            get
            {
                return B;
            }
        }
        int C
        {
            set
            {
                if (B <= value && value <= top)
                {
                    C = value;
                }
            }
            get
            {
                return C;
            }
        }

    }
}

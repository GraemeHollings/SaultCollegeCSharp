using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Adder
    {
        public event EventHandler OnMultipleOfFiveReached;

        public int Add(int x, int y)
        {
            int iSum = x + y;
            //based on the previously explained conditions (explained in the previous projects)
            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
                //calling the method (note to self: research why it has these params.)
            { OnMultipleOfFiveReached(this, EventArgs.Empty); }
            return iSum;
        }

    }
}

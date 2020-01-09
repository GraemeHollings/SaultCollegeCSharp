using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Adder
    {
        //declaring a delegate and event
        public delegate void dgEventRaiser();
        public event dgEventRaiser OnMultipleOfFiveReached;

        public int Add(int x, int y)
        {

            //iSum for adding two ints together
            int iSum = x + y;

            //findind out if it is a mutiplee of five AND if the event isnt null
            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
               //then call the method
            { OnMultipleOfFiveReached(); }
            return iSum;
        }
    }
}

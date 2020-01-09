using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4B_1
{
    //this is the publisher class
    class Adder
    {
        //this classes functionality is adding two values passed into it,
        //and we also define an event handler for recognizing if a number with a multiple of 5 is reached.
        //this event handler is also based on the class for dealing with multiple of 5 event arguments.
        public event EventHandler<MultipleOfFiveEventArgs> OnMultipleOfFiveReached;
        public int Add(int x, int y)
        {
            int iSum = x + y;
            
            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
                //creating a new instance of the multiple of five class, and passing the iSum into it
                //and attaching the event to that instance.
            { OnMultipleOfFiveReached(this, new MultipleOfFiveEventArgs(iSum)); }
            return iSum;
        }


    }
}
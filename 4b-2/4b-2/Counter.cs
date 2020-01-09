using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4b_2
{
    class Counter
    {
        //class fields
        private int threshold;
        private int total;

        //constructor for the passed threshold 
        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        
        public void Add(int x)
        {
            //adding to the total var
            total += x;
            //if total is less than the threshold number, then the method param is empty.
            if (total >= threshold)
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            //event for showing when the threshold is reached.
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        //event declaration
        public event EventHandler ThresholdReached;




    }
}

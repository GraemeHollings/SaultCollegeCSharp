using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Counter
    {
        private int limit;
        private int total;

        public Counter(int passedThreshold)
        {
            limit = passedThreshold;
        }

        //from where we gather user input and add onto a variable in the main method, 
        //this is where the variable is passed
        public void Add(int x)
        {

            total += x;
            if (total >= limit)
            {
                //new instance of the reached event class
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                //assigning properties
                args.Limit = limit;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        //here is where the threshold reached event is published
        //Eventhandler<TEventArgs> just as the question specified; the built in delegate
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    }

   
}


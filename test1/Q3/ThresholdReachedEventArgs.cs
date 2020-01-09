using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    
        public class ThresholdReachedEventArgs : EventArgs
        {
        //properties for the limit and time reached
            public int Limit { get; set; }
            public DateTime TimeReached { get; set; }
        }
    }


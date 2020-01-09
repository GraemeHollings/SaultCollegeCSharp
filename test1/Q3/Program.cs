using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new counter object that is passed a random value between 1 and 10
            Counter c = new Counter(new Random().Next(10));
            //this is where the event in the other class is subscrubed to
            c.ThresholdReached += c_ThresholdReached;

            //recieving input from the user to add to the counter
            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        //this is the event handler that expects the event of limit reacher to be triggered.
        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Limit, e.TimeReached);
            
        }
    }
    }


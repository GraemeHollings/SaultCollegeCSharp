using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4b_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //new counter object
            Counter c = new Counter(new Random().Next(10));
            //subcscring to threshold reached
            c.ThresholdReached += c_ThresholdReached;

            //output
            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }



        }

        //method that was subscrubed to previously
        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Environment.Exit(0);
        }



    }
}

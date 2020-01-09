using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1a_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a new hello class object for use in the main method. 
            Hello h1 = new Hello();
 
            //a for loop designed to iterate through the lightyear enum in its length.
            for (int i = 0; i < Enum.GetValues(typeof(lightyear)).Length; i++)
            {
                //creates a string variable that we can use to identify the new Hello object, and the enum and prints it out inside of the range of "i".
                String w1 = String.Format("{0} {1}", h1.Howdy, h1.everything((lightyear)i));
                Console.WriteLine(w1);


            }


            Console.ReadKey();
        }
    }
}

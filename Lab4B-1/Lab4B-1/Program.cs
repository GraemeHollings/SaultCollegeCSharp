using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4B_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new instance of the adder class. 
            Adder a = new Adder();

            //attaching the event to the method.
            a.OnMultipleOfFiveReached += a_MultipleOfFiveReached;

            //sending values and outputtubg
            int iAnswer = a.Add(4, 3);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            iAnswer = a.Add(4, 6);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            Console.ReadKey();

        }


        //method that is subcribed to the event
        static void a_MultipleOfFiveReached(object sender, MultipleOfFiveEventArgs e)
        {
             Console.WriteLine("Multiple of five reached: ", e.Total);
        }
    }


}


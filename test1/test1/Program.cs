using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //new circle object
            Circle<double> r1 = new Circle<double>();

            //variables to be sent to the class
            int sample = 5;
            double sample2 = 2.5;

            //outputting the calculated area
            Console.WriteLine("The area is (double) " + r1.CalculateArea(sample2));
            Console.WriteLine("The area is (int) " + r1.CalculateArea(sample));

            Console.Read();
        }
    }
}

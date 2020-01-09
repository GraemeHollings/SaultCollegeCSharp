using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating a list of object rectangle, to output both datatypes in int and double
            Rectangle<double> small = new Rectangle<double>();
            Rectangle<int> med = new Rectangle<int>();


            //setting length and width for both lists
            small.Length = 5.3;
            small.Width = 2.7;


            med.Length = 3;
            med.Width = 2;

            small.calcArea();
            med.calcArea();

            

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{


public delegate int dgPointer(int a, int b);

    class Program
    {
        static void Main()
        {
            //adds a new object of adder 
            Adder a = new Adder();
            //instatiating the delegate of the previously declared object.
            dgPointer pAdder = new dgPointer(a.Add);
            //sending ints to the method through the delegates
            int iAnswer = pAdder(4, 3);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            // Returns “iAnswer = 7”
        }
    }


}

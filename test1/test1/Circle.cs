using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Circle<T>

    {
        public T radius { get; set; }

        //the variable is recieved
        public T CalculateArea(T x)
        {
            //radius1 is dynamic so it can be used
            dynamic radius1 = x;

            //calculation is done
           radius1 = (3.14 * radius1);

            

          




            //returning that value
            return radius1;
        }



    }
}

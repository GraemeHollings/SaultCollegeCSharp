using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A_2
{
    class Rectangle<T>
    {
       //private fields
        private T length;
        private T width;


        //getters and setters to access those fields
        public T Length
        {
            get { return length; }
            set { length = value; }


        }

        public T Width {

            get { return width; }
            set { width = value; }

        }
        
        //area is calculated and output is printed here
        public T calcArea()
        {
            T area = (dynamic) length * width;
            Console.WriteLine("The area is " + area);
            return area;

            
        }
    }
  }



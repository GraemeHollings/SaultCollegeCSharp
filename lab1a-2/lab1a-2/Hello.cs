using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1a_2
{
    //declares an enum for adding to the second part of the string concatenation in the main method.
    public enum lightyear {world, galaxy, universe }



    class Hello
    {
        private string greeting = "Hello";

        //this is a property for the Hello class.
        public string Howdy
        {
            //getters and setters for the greeting field.
            get { return greeting; }
            set { greeting = value; }

        }

        //a method that creates the world portion of the string, and returns it for use in the main method. 
        public string returnWorld()
        {
            string world = "World";
            return world;
            
        }


        //creates a return method for the lightyear enum so it is accesible in the main method.
        public string everything(lightyear l1)
        {
            return l1.ToString();

        }

    }
}

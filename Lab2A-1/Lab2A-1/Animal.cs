using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A_1
{
   
        public abstract class Animal
        {

        //property for the animal class
            protected string name;
            public string Name
            {
                //getters and setters for the name field
                get { return name; }
                set { name = value; }
            }

        
        //method animal will point to the name propety and will equal the following string.
            public Animal() => name = "The animal with no name";

        //constructor for expecting a new string input outside of the class to be sent to name
            public Animal(string newName) => name = newName;

        //declaring the feed method
            public void Feed() => WriteLine($"{name} has been fed.");
        }
    }


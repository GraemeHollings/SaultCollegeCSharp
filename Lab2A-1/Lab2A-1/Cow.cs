using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A_1
{
    public class Cow : Animal
    {

        //milk method
        public void Milk() => Console.WriteLine($"{name} has been milked.");

        //expecting a new string to be fed, inherting from the newName base class.
        public Cow(string newName) : base(newName) { }
    }
}


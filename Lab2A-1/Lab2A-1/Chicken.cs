using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A_1
{
    public class Chicken : Animal
    {


        //method for laying an egg.
        public void LayEgg() => Console.WriteLine($"{name} has laid an egg.");

        //expecting a new string to be fed into chicken, inheriting from the base newName constructor.
        public Chicken(string newName) : base(newName) { }
    }
}

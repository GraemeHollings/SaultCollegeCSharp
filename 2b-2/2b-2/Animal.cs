using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2b_2
{
   public class Animal :IComparable<Animal>
    {

        //property for the animal class
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Age = age;
            Name = name;

        }


        //copmaring the old name to the new name
        public int CompareTo(Animal other)
        {
            return (this.Name.CompareTo(other.Name));
            
        }
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_4
{
    //This program is using iComparable to compare two objects.
    class Person : IComparable
    {
        //variable declarations for class objects.
        public string Name;
        public int Age;

        //assigning person arguments as variables, so they are recognized as such.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        
        public int CompareTo(object obj)
        {
            //if the object is a Person object
            if (obj is Person)
            {
                //create a new person object called "otherPerson" and assign that object as that
                //might want some further explanation on this portion of the code.
                Person otherPerson = obj as Person;

                //this is what specifies to order by age. 
                return this.Age - otherPerson.Age;
            }
            else
            {
                //if false, throw this.
                throw new ArgumentException("Object to compare to is not a Person object.");

            }

        }
    }
}

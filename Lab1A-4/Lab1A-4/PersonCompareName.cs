using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1A_4
{
    //this is using IComparer to compare two objects.
    public class PersonComparerName : IComparer
    {
        //new IComparer object.
        public static IComparer Default = new PersonComparerName();

        //method that compares two objects.
        public int Compare(object x, object y)
        {
            //if x is a person object, and y is a person object:
            if (x is Person && y is Person)
            {

                //return the two objects, specifying the name for both x and y. This is what allows us to sort by name.
                return Comparer.Default.Compare(((Person)x).Name, ((Person)y).Name);
            }
            else
            {
                //throw this exception if it evaluates to false
                throw new ArgumentException(
                   "One or both objects to compare are not Person objects.");
            }
        }
    }
}

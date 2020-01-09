using System;
using System.Collections;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            //array list is populated with person objects. filled with a name and age.
            list.Add(new Person("Rual", 30));
            list.Add(new Person("Donna", 25));
            list.Add(new Person("Mary", 27));
            list.Add(new Person("Ben", 44));
            WriteLine("Unsorted people:");

            //each for loop iterates in the same way, but its once done to the list that changes and is the reason why we get different outputs.
            //this one just outputs the objects.
            
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"{(list[i] as Person).Name } ({(list[i] as Person).Age })");
            }

            WriteLine();

            WriteLine("People sorted with default comparer (by age):");
            //this is the portion that takes the list and uses it by its default sort/compare usage. Using IComparable (shown in Person.cs)
            //this one sorts by age (numerically)
            list.Sort();


            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"{(list[i] as Person).Name } ({(list[i] as Person).Age })");
            }
            WriteLine();

            //This portion sorts using the IComparable interface, meaning it sorts by using the way in which was specified in the PersonCompareName class.
            //this one sorts by name (alphabetically)
            WriteLine("People sorted with nondefault comparer (by name):");
            list.Sort(PersonComparerName.Default);

            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"{(list[i] as Person).Name } ({(list[i] as Person).Age })");
            }
            ReadKey();
        }
    }
}

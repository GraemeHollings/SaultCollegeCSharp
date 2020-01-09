using _2b_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2b_2
{

    class Program
    {

        public static List<Animal> animalList = new List<Animal>();


        static void Main(string[] args)
        {
            //adding ages and names to the lsit
            animalList.Add( new Animal ("Jeff", 20));
            animalList.Add( new Animal ("Sven", 15));
            animalList.Add( new Animal ("Cnl Soft Mittens", 15));

            //sorting that list
            animalList.Sort();

            //printing the names in animal
            foreach (Animal animal in animalList)
            {
                Console.WriteLine("Sorted by name: " + animal.Name);
            }

            //declaring a new list for comparer
            List<Animal> animalList2 = new List<Animal>();

            //adding the new list to the same range as the old list
            animalList2.AddRange(animalList);

            //creating a comparer object
            Comparer age_sort = new Comparer();

            //sorting the 2nd lsit 
            animalList2.Sort(age_sort);

            //outputting that
            foreach (Animal ani in animalList2)
            {
                Console.WriteLine("Sorted by age: " + ani.Age);
            }

            Console.Read();


        }
    }
}

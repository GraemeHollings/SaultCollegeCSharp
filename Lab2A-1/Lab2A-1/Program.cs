using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a new list of the type animal
            List<Animal> animalCollection = new List<Animal>();

            //adding new cows and chickens, because the cow and chicken class BOTH inherit from the
            //animal class, there are no errors and the types are compatible. 
            animalCollection.Add(new Cow("Simon"));
            animalCollection.Add(new Chicken("Donna"));

            //saying for every animal object in our animal 
            foreach (Animal myAnimal in animalCollection)
            {
                //call the feed method to those objects
                myAnimal.Feed();
            }
            Console.ReadKey();




        }
    }
}

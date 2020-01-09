using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2a_3
{
    class Program : Animal
    {
        static void Main(string[] args)
        {
            //new member of the rodent class and assigning attributes
            Rodent chinchilla = new Rodent();
            chinchilla.age = 42;
            chinchilla.eye_colour = "black";
            chinchilla.fur_colour = "brown";
            chinchilla.name = "Connor";
            
            chinchilla.weight = null;

            //printing attributes with the example of ??
            Console.WriteLine("Name: " + chinchilla.name);
            Console.WriteLine("Age: " + chinchilla.age);
            Console.WriteLine("Eye Colour: " + chinchilla.eye_colour);
            Console.WriteLine("Hair Colour: " + chinchilla.fur_colour);
            Console.WriteLine($"Weight: {chinchilla.weight ?? 5.5}");


            





            Console.Read();

        }
    }
}

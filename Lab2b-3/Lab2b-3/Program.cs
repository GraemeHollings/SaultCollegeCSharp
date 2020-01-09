using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b_3
{
    class Program
    {

        //ternary operation
       public static int Ternary(int? tern)
        {
            //if it is null, fill it with 0, if not, cast it to int
            int new_tern = tern == null ? 0 : (int)tern;
            return new_tern;

        }


        //coalescing operation
       public static int Coalescing(int? coal)
        {
            //if it is null, assign it 1, if not leave it as is.
            int new_coal = coal ?? 1;
            return new_coal;
        }

        //hasvalue operation
        public static int? HasValue(int? has)
        {
            //if it has a value, just reprint it
            if (has.HasValue)
            {
                Console.WriteLine(has);
            }
            else
            {
                //assign it to 2.
                has = 2;
            }

            return has;
        }


        static void Main(string[] args)
        {
            //sending null
            Console.WriteLine("Ternary sending null" + Ternary(null));
            Console.WriteLine("Coalescing sending null" + Coalescing(null));
            Console.WriteLine("HasValue sending null" + HasValue(null));

            //sending numbers
            Console.WriteLine("Ternarary sending a number " + Ternary(6));
            Console.WriteLine("Coalescing sending a number " + Coalescing(7));
            Console.WriteLine("HasValue sending a number " + Coalescing(2));

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //new instance ob the object
                Adder a = new Adder();

                //subscribing to the event
                a.OnMultipleOfFiveReached += new Adder.dgEventRaiser(a_MultipleOfFiveReached);

                int iAnswer = a.Add(4, 3);
                Console.WriteLine("iAnswer = {0}", iAnswer);
                iAnswer = a.Add(4, 6);
                Console.WriteLine("iAnswer = {0}", iAnswer);
                Console.ReadKey();
            }

            static void a_MultipleOfFiveReached()
            {
                Console.WriteLine("Multiple of five reached!");
            }

        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1a2
{
    public class myClass {

        public string hello;

        public string sayHello
        {
            get{ return hello; }
            set { hello = value; }
        }
         


    }


    class Program : myClass
    {
        static void Main(string[] args)
        {
            var example = new myClass { sayHello = "Hello" };
            Console.WriteLine(myClass.sayHello{example});


            Console.Read();

        }
    }
}

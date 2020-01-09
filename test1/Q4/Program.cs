using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom<Student> output = new Classroom<Student>();

            Student gr1 = new Student();

            gr1.Name = "Graeme";
            gr1.Saying = "I Love C#";

            output.Add(gr1);


            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {

        public static List<Student> classList = new List<Student>();


        static void Main(string[] args)
        {

            classList.Add(new Student("Graeme", 19));
            classList.Add(new Student("Steve", 85));
            classList.Add(new Student("Connor", 32));
            classList.Add(new Student("Joey", 21));


            classList.Sort();


            foreach (Student student in classList)
            {
                Console.WriteLine("Sorted by name (using IComparable): " + student.Name);
            }


            Console.Read();
            



        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //new class room object 
            ClassRooms<School, Person> output = new ClassRooms<School, Person>();
            //populating the name property of the base classes with these strings 
            output.School = new School { Name = "Sault College" };
            output.Person = new Person { Name = "Graeme" };
           
            //send these strings and instance of the two student storing classes
           //the reason why this works is because the dictionary in the school class expects
           //a string and also a person object, and the student storting classes both derive from the person base class
            output.student.Add("Barry", new StudentStoring1());
            output.student.Add("Bruce", new StudentStoring2());

            //new teacher object and also assigning a name and course code
            Teacher t1 = new Teacher();
            t1.Name = "Jeb";
            t1.code = "CSD331";

            //outputting all of these objects
            Console.WriteLine(output.School.Name);
            Console.WriteLine(output.Person.Name);
            //passing that teacher object to the getClassList method where it will be recieved.
            Console.WriteLine(output.GetClassList(t1));


            Console.ReadKey();
        }
    }
}

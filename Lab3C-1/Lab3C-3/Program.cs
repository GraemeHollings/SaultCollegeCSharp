using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //new class room object 
            ClassRooms<School, Person> output = new ClassRooms<School, Person>();

            output.School = new School { Name = "Sault College" };


            //making a teacher assistant for later use.
            Person assistant1 = new Person();
            //declaring new students
            StudentStoring1 peter = new StudentStoring1();
            StudentStoring2 bill = new StudentStoring2();

            //givving new students a name and a gpa
            peter.Name = "Peter";
            peter.score = 3.0;
            bill.Name = "Bill";
            bill.score = 3.4;




            //send these strings and instance of the two student storing classes
           //the reason why this works is because the dictionary in the school class expects
           //a string and also a person object, and the student storting classes both derive from the person base class
            output.student.Add("Barry", new StudentStoring1());
            output.student.Add("Bruce", new StudentStoring2());

            //new teacher object and also assigning a name.
            Teacher t1 = new Teacher();
            t1.Name = "Jeb is a teacher.";
            //here we're assigning the t1 teacher object to have an assistant that is an
            //instance of a person base class.
            t1.assistant = assistant1;
            //here we assign the name to be mohammed. this works because this is assigned 
            //BEFORE we send the t1 object to the getClasList method.
            t1.assistant.Name = "Mohammed";


      


            //new instance of the professor class.
            Professor p1 = new Professor();
            p1.Name = "Graeme is a professor.";

            //outputting all of these objects
            //Passing students to get class list
            Console.WriteLine(output.GetClassList(peter));
            Console.WriteLine(output.GetClassList(bill));
            Console.WriteLine("-------------------------");
            //passing that teacher and professor objects to the getClassList method.
            Console.WriteLine(output.GetClassList(t1));
            Console.WriteLine(output.GetClassList(p1));


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_3
{
    class ClassRooms<S, P>
        
        
    {
             //new dictionary  that expects a new string and person object
            public Dictionary<string, Person> student = new Dictionary<string, Person>();
        
            //here we define the constraints to be a person object and a school object
            public P Person { get; set; }
            public S School { get; set; }



        //a teacher object is accepted an an argument here
        public string GetClassList<T>(T Person)
            
            {
            

                //Need to protect the classroom from undesirable schools.
            if (!(School is School))
                {
                    return "School is not valid";
                }

            //checking to see if the argument being passed is a 'Teacher' Object
            if (Person is Teacher)
            {
                //printing out the teacher name and catchphrase and the assistant
                return "Teacher: " + (Person as Teacher).Name + " \n" + (Person as Teacher).Saying + " \n" +  "The assistant is " +
                    (Person as Teacher).assistant.Name;
                    
            }

            //checking to see if the argument being passed is a professor object.
            if (Person is Professor)
            {
                //outputting the professors name
                return "Professor: " + (Person as Professor).Name + " \n" + (Person as Professor).Saying;
            }

            //if the parameter being passed is JUST a person, which at this point is only students
            
            if (Person is Person) {

                string ret = "";
                
                        //the only output their name, what their unique greeting is, and their score(their GPA)
                       return  (Person as Person).Name + " says " + (Person as Person).Saying + "\n"
                        + " students score is " + (Person as Person).score;
                }
            

            return "The School Name is: " + (School as School).Name;


            }
        
    }
}
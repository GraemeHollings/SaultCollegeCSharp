using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_1
{
    class ClassRooms<S, P>
        
        
    {
             //new dictionary  that expects a new string and person object
            public Dictionary<string, Person> student = new Dictionary<string, Person>();
        
            //here we define the constraints to be a person object and a school object
            public P Person { get; set; }
            public S School { get; set; }
            


            public string GetClassList()
            {

                //Need to protect the classroom from undesirable schools.
            if (!(School is School))
                {
                    return "School is not valid";
                }

                string ret = "";

                //for every item in the dictionary
                foreach (var item in student)
                {
                    //if the item(aka the dictionary) has value and is a person object(?)
                    if (item.Value is Person)
                        //take that item(which is assigned to the dictionary) and retrieve the key(which is the string)
                        //and then take the person object and reference the 'saying' method inside of those derived classes
                        //THIS is why we get unique phrases from each dictionary addition, because it references saying
                        ret += item.Key + " says " + (item.Value as Person).Saying + "\n";
                }

                return (School as School).Name + " enrollment: " + ret;
            }
        
    }
}
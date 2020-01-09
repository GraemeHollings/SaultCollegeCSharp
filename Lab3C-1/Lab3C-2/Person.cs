using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_2
{
    class Person 
    {
        //previously explained all of this funcitonality in the other program
        public string Name { get; set; }



        public virtual string Saying
        {
            get
            {
                string basePerson = "Hello";
                return basePerson;
            }
            }

      
    }
}

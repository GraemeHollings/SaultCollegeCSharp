using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_1
{
    class Person 
    {
        public string Name { get; set; }


        //virtual so the method can be overrwritten
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

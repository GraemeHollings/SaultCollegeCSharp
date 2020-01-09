using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_1
{
    class StudentStoring2 : Person
    { 

        public string School { get; set; }

        //unique message method, and it overrides the saying method
        public override string Saying
        {
            get
            {
                string Hello_2 = "Greetings!";
                return Hello_2;

            }
        }


    }
}

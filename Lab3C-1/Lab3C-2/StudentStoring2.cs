﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_2
{
    class StudentStoring2 : Person
    { 
        public string School { get; set; }

        //previously explained all of this funcitonality in the other program
    
        public void Storing()
        {
            Person person2 = new Person();
            person2.Name = "John";


        }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_1
{
    class StudentStoring1 : Person
    {

        public string School { get; set; }

        //unique message method overrides the base saying method
        public override string Saying
        {
            get {
                string Hello_1 = "Howdy";
                return Hello_1;
            } 
        }

    }

}

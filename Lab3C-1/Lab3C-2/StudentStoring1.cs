using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_2
{
    class StudentStoring1 : Person
    {
        //previously explained all of this funcitonality in the other program
        public string School { get; set; }

        public override string Saying
        {
            get {
                string Hello_1 = "Howdy";
                return Hello_1;
            } 
        }

    }

}

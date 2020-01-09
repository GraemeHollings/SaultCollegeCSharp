using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_3
{
    class Professor : Person, ITeacherAssistant<StudentStoring1>
    {


        public string Name { get; set; }

        //the new saying override (i know not nessecary but hey)
        public override string Saying
        {
            get
            {
                string Hello_3 = "I'm a professor!";
                return Hello_3;

            }
        }

        //property from the ICourseCode so code can be manipulated
        public StudentStoring1 teacherAssistant { get; set; }
    }
}

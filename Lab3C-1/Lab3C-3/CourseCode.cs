using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_3
{
    //defined a new interface that holds a property of the course code string.
    interface ITeacherAssistant<T> where T : Person
    {
         T teacherAssistant { get; set; }


       
    }
}

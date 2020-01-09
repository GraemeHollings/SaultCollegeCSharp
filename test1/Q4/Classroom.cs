using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Classroom<T>
        where T : Student
    {
        public Dictionary<string, T> Student = new Dictionary<string, T>();

        Student sd1 = new Student();

        public string getSaying()
        {

            return sd1.Name;
        }


        public string ClassList()
        {

            string ret = "";

            foreach (var item in Student)
            {
                if (item.Value is Student)
                {
                   ret += item.Key + "says" + (item.Value as Student).Saying;
                }
            }

            return " ";
        }


    }
}

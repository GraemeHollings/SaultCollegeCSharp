using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Student
    {

       //properties of student

        private string firstNameVal;

        public string Firstname { get { return firstNameVal; } set { firstNameVal = value; } }

        private string lastNameVal;

        public string Lastname { get { return lastNameVal; } set { lastNameVal = value; } }



       
        private double ageVal;

        public double Age

        {
            get
            {
                return ageVal;
            }
            set
            {
                if (value != ageVal)
                {
                    ageVal = value;
                }
            }

        }

        //constructor for student
        public Student(string first, string last, double age)
        {
            this.firstNameVal = first;
            this.lastNameVal = last;
            this.ageVal = age;
        }


    }
}

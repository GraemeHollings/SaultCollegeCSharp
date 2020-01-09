using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Student


    {

        //properties of student. setting firstname, lastname, and age.
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



    }
}

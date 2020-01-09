using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Person
    {
        private string nameVal;

        public string Name { get { return nameVal; } set { nameVal = value; } }

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



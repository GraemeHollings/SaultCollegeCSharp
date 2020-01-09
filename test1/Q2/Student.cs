using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Student : IComparable<Student>
    {


        private int age;
        private string name;

        public int Age;
        public string Name;

        public Student(string name, int age)
        {

            Name = name;
            Age = age;

        }




        public int CompareTo(Student other)
        {
            return (this.Name.CompareTo(other.Name));
        }
    }
}

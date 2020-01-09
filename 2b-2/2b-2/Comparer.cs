using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2b_2
{
    class Comparer : IComparer<Animal>
    {
        int IComparer<Animal>.Compare(Animal x, Animal y)
        {
            //ordering the ages using iComparer
            if (x.Age > y.Age) return 1;
            else if (x.Age < y.Age) return -1;
            else return 0;

        }
    }
}

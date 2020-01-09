using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2b_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring lists and adding elements into those lists.
            List<int> list1 = new List<int>();
            IList<int> list2 = new List<int>();

            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            list1.Add(40);
            list1.Add(50);

            IList<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("five");

            //Adding elements using obkect initializer syntax.
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };

            //AddRange
            IList<int> intList1 = new List<int>();
            intList1.Add(10);
            intList1.Add(20);
            intList1.Add(30);
            intList1.Add(40);

            List<int> intList2 = new List<int>();

            intList2.AddRange(intList1);

            //accessing list using for loop example:
            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);


            //adding and removing elements from a list.
            //remove 10 out of the list
            intList.Remove(10);
            //remove the third element out of list.
            intList.RemoveAt(2);



            //true for all example.
            //have a few questions regarding the usage of true for all.
            bool isPositiveInt(int i)
            {

                return i > 0;
            }

            /*this is a boolean variable that determines whether all of the object inside of 
            the list is all postiive integers. it is taking the list and running it through
            the method*/
            bool res = list1.TrueForAll(isPositiveInt);



            Console.Read();


        }
    }
}

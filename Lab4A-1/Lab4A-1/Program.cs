using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//declaring the delegate of type int. 
delegate int NumberChanger(int n);
namespace Lab4A_1
{
    class Program
    {
        static int num = 10;

        //adding the class variable num
        public static int AddNum(int p)
        {
            //num is now num + P
            num += p;
            return num;
        }

        //multiplying num
        public static int MultNum(int q)
        {
            
            num *= q;
            return num;
        }

        //simply accessing num.
        public static int getNum()
        {
            return num;
        }


        static void Main(string[] args)
        {
            //creating an instance of the delegate, referencing the addNum method and multNum. 
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);


            //sending values to those methods, because of the instance we just created.
            nc1(25);
            //outputig that instance, getNum is used because the instance of num has been changed.
            Console.WriteLine("Value of Num: {0}", getNum());
            //sending values to multNum
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}

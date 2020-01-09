using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);
namespace Multicasting_Delegate
{
    class Program
    {
        
        static int num = 10;
       
        //adding the class variable num
        public static int AddNum(int p)
        {
            num += p;
            return num;
            //num is now 15
           
        }
        //multiplying num
        public static int MultNum(int q)
        {
           
            num *= q;
            return num;
            //num now equals 75.
        }

        //simply accessing num.
        public static int getNum()
        {
            return num;
        }


        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);


            //delegate "nc" is assigned to nc1, and then assigned to nc2. 
            //first it is sent to the addNum method, then it is sent to the multnum function, which is why the result is 75.
            nc = nc1;
            nc += nc2;

            //sending 5 to addNum
            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();


        }
    }
}

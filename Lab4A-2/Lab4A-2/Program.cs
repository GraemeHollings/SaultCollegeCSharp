using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4A_2
{
    class Program
    {
        //defines a delgate and an event of a delegate type.
        public delegate void delPrint();
        //because the event is of the type of the delagate, whenever the delegate is being used, the event will be triggered.
        public static event delPrint delPrintEvent;


        //this method is just designed to print a number in its regular format. 
        public static void PrintNumber(int num)
        {
            //before printing, call the delegate method and let the user know that the event is taking place. 
            //this syntax is being used in all methods.

            if (delPrintEvent != null)
                delPrintEvent();


            Console.WriteLine("Number: {0,-12:N0}", num);


        }

        //printing the number in decimal format.
        public static void PrintDecimal(int dec)
        {
            if (delPrintEvent != null)
                delPrintEvent();


            Console.WriteLine("Decimal: {0:G}", dec);
        }

        //printing it in a money format.
        public static void PrintMoney(int money)
        {
            if (delPrintEvent != null)
                delPrintEvent();


            Console.WriteLine("Money: {0:C}", money);
        }






        static void Main(string[] args)
        {
            //sending values to each method. 
            PrintNumber(5);
            PrintDecimal(7);
            PrintMoney(3);


            Console.Read();

        }
    }
}

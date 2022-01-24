using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number that will be multiplied by 50:");
            string yourNumber = Console.ReadLine();
            int yourNum = Convert.ToInt32(yourNumber); //has to convert input string to int so it can be math operated on
            int total = yourNum * 50;
            Console.WriteLine("The total is: " + total);

            Console.WriteLine("Input a number that will have 25 added to it:");
            string yourNumber1 = Console.ReadLine();
            int yourNum1 = Convert.ToInt32(yourNumber1);
            int total1 = yourNum1 + 25;
            Console.WriteLine("The total is: " + total1);

            Console.WriteLine("Input a number that will be divided by 12.5:");
            string yourNumber2 = Console.ReadLine();
            double yourNum2 = Convert.ToDouble(yourNumber2); //had to make it a double data type for the decimals
            double total2 = yourNum2 / 12.5;
            Console.WriteLine("The total is: " + total2);

            Console.WriteLine("Input a number that will check if it is greater than 50:");
            string yourNumber3 = Console.ReadLine();
            int yourNum3 = Convert.ToInt32(yourNumber3); //converting string to int to be compared to have bool check if it is true/false
            bool yourAnswer = yourNum3 > 50;
            Console.WriteLine(yourAnswer);

            Console.WriteLine("Input a number that will be divided by 7 and will return the remainder:");
            string yourNumber4 = Console.ReadLine();
            int yourNum4 = Convert.ToInt32(yourNumber4);
            int total4 = yourNum4 % 7;
            Console.WriteLine("The remainder is: " + total4);


            Console.ReadLine();


        }
    }
}

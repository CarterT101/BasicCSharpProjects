using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = new Operation(); //instance

            Console.WriteLine("Input a number to be multipled by 3"); 
            int yourNum = Convert.ToInt32(Console.ReadLine()); //converting readline to int
            int result = oper.Multi(yourNum); //using method to multiply user input
            Console.WriteLine(result);

            Console.WriteLine("Input a decimal number to be multipled by 3");
            decimal yourNum1 = Convert.ToDecimal(Console.ReadLine()); //converting to decimal
            result = oper.Multi(yourNum1);
            Console.WriteLine(result);

            Console.WriteLine("Input a number to be multipled by 3");
            int yourNum2 = Convert.ToInt32(Console.ReadLine());
            result = oper.Multi(yourNum2);
            Console.WriteLine(result);



            Console.Read();
        }
    }
}

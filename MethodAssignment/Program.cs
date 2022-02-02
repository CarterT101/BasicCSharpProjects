using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = new Operation(); //instance

            Console.WriteLine("Input a number");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number if you'd like");
            int yourNum1 = Convert.ToInt32(Console.ReadLine());
            int result = oper.Multi(mult: yourNum, mult1: yourNum1);
            Console.WriteLine(result);



            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignmentDraft2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = new Operation();

            Console.WriteLine("Input a number");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number if you'd like");
            string yourNum1 = Console.ReadLine();
            if (yourNum1 == "")
            {
                int result = oper.Multi(yourNum);
                Console.WriteLine(result);
            }
            else
            {
                int yourNum2 = Convert.ToInt32(yourNum1);
                int result = oper.Multi(yourNum, yourNum2);
                Console.WriteLine(result);
            }



            Console.Read();
        }
    }
}

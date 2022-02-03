using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = new Operation();

            Console.WriteLine("Input a number to be divided by 2");
            int yourNum = Convert.ToInt32(Console.ReadLine());

            oper.Div(yourNum);

            oper.Mult(yourNum);


            Console.WriteLine("Input second number");
            int yourNum1 = Convert.ToInt32(Console.ReadLine());
            int result = oper.Mult(yourNum, yourNum1);

            Console.WriteLine("This is your result if the first inputted number multiplied by second inputted number:\n{0}", result);

            Console.WriteLine("Input another number");
            yourNum = Convert.ToInt32(Console.ReadLine());

            result = Operation.Times(yourNum);
            Console.WriteLine("This is your number times 10:\n{0}", result);

            Console.Read();




        }
    }
}

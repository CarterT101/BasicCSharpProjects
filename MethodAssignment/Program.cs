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

            Console.WriteLine("Input a number to be multiplied by a number of your choice or by 5");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            bool question = false;
            while (!question)
            {
                Console.WriteLine("Do you want to enter a second answer, yes or no"); 
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Input a second number");
                    int yourNum1 = Convert.ToInt32(Console.ReadLine());
                    int result = oper.Multi(yourNum, yourNum1); //inputs both variables into method
                    Console.WriteLine(result);
                    question = true;
                }
                else if (answer == "no")
                {
                    int result = oper.Multi(yourNum); //only one number is entered into method since method has default value for second parameter
                    Console.WriteLine(result);
                    question = true;
                }
                else
                {
                    Console.WriteLine("Please enter 'yes' or 'no'");
                }
            }


            Console.WriteLine("Thanks for playing");

            Console.Read();
        }
    }
}

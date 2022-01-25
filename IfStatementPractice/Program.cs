using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //if (yourName == "Carter")
            //{
            //    Console.WriteLine("Hello Carter");
            //}
            //else if (yourName != "Carter") 
            //{
            //    Console.WriteLine("Your name is " + yourName);
            //}

            //Console.WriteLine("Input a number:");
            //string num1 = Console.ReadLine();
            //int number1 = Convert.ToInt32(num1);
            //Console.WriteLine("Input another number:");
            //string num2 = Console.ReadLine();
            //int number2 = Convert.ToInt32(num2);
            //if (number1 > number2)
            //{
            //    Console.WriteLine("Your first number, " + number1 + ", is bigger than your second number, " + number2 + ".");
            //}
            //else if (number1 <= number2)
            //{
            //    Console.WriteLine("Your first number, " + number1 + ", is less than or equal to your second number, " + number2 + ".");
            //}
            //else
            //{
            //    Console.WriteLine("How did you manage to get this answer?");
            //}

            int num3 = 9;
            int num4 = 8;

            string result = num3 > num4 ? "num3 is larger than num4" : "num3 is smaller than num4";
            Console.WriteLine(result);


            Console.ReadLine();

            
        }
    }
}

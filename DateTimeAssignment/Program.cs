using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //puts the current time in console
            Console.WriteLine("Input a number");
            int yourNum = Convert.ToInt32(Console.ReadLine()); //converts user input to int
            DateTime future = DateTime.Now.AddHours(yourNum); //multiplying hours from current datetime by userinput
            Console.WriteLine("It will be {0} in {1} hours.", future, yourNum); //printing answer
            Console.Read();
        }
    }
}

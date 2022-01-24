using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy. \nStudent Daily Report.");
            Console.WriteLine("What is your name?:");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?:");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?:");
            string pageNumber = Console.ReadLine(); //grabs input and converts to integer in next line
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please respond with \"true\" or \"false\".");
            string yourHelp = Console.ReadLine(); //grabs input and converts to bool in next line
            bool helpAnswer = Convert.ToBoolean(yourHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics:");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific:");
            string yourFeed = Console.ReadLine();
            Console.WriteLine("How many hours did you work today?:");
            string yourHours = Console.ReadLine(); //grabs input and converts to int in next line
            int hoursWorked = Convert.ToInt32(yourHours);
            Console.WriteLine("Thank you for your answers. \nAn Instructor will respond to this shortly. \nHave a great day!");
            Console.Read();

        }
    }
}

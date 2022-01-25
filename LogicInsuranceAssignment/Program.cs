using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInsuranceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine(); //grabs input and converts to int 
            int age = Convert.ToInt32(yourAge);
            Console.WriteLine("Have you ever had a DUI? Please answer true or false:");
            string yourDUI = Console.ReadLine(); //grabs answer and coverts to bool
            bool dui = Convert.ToBoolean(yourDUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine(); //grabs string input and converts to int
            int speedTicket = Convert.ToInt32(speedingTickets);

            bool qualify = (age >= 15 && dui == false && speedTicket <= 3); //compares all answers and all of them have to follow the comparisons in order to say true
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualify);
            Console.ReadLine();

        }
    }
}

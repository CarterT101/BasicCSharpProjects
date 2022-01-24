using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a simple program
            //Console.WriteLine("What is your name?:");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Hello, " + yourName + "!");
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?:");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemp = -23;
            //char randomLetter = 'X';
            //char questionMark = '\u2103';
            //Console.WriteLine(questionMark);
            //Console.ReadLine();

            decimal moneyInBank = 100.5m; // m is not million, what you have to do when you use a decimal so compiler knows
            double heightinCentimeters = 211.30202092;
            float secondsLeft = 2.62f;
            short temperatureonMars = -341;
            string myName = "Carter";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(rainingStatus);
            Console.ReadLine();




        }
    }
}

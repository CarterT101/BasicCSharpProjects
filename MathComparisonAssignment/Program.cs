using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1\nHourly Rate:");
            string hourlyRate1 = Console.ReadLine();
            int hourRate1 = Convert.ToInt32(hourlyRate1);
            Console.WriteLine("Hours worked per week:");
            string hoursWorked1 = Console.ReadLine();
            int hourWork1 = Convert.ToInt32(hoursWorked1);
            Console.WriteLine("Person 2\nHourly Rate:");
            string hourlyRate2 = Console.ReadLine(); //gathering input from user and converting to integer to perform math and boolean comparisons on
            int hourRate2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Hours worked per week:");
            string hoursWorked2 = Console.ReadLine();
            int hourWork2 = Convert.ToInt32(hoursWorked2);

            int salary1 = (hourRate1 * hourWork1) * 52; //multiplying by 52 for 52 weeks in a year
            int salary2 = (hourRate2 * hourWork2) * 52;
            bool salaryCompare = salary1 > salary2; 

            Console.WriteLine("Annual Salary of Person 1: " + salary1);
            Console.WriteLine("Annual Salary of Person 2: " + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2:\n" + salaryCompare);
            Console.ReadLine();

        }
    }
}

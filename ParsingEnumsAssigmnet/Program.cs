using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssigmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a day of the week:");
            foreach (DaysOfTheWeek day in Enum.GetValues(typeof(DaysOfTheWeek))) //printing each day of the week to the console by getting values of enum DaysOfTheWeek
            {
                Console.WriteLine(day);
            }
            try
            {
                string yourDay = Console.ReadLine();
                DaysOfTheWeek weekday = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), char.ToUpper(yourDay[0]) + yourDay.Substring(1)); //capitilize first letter of input because case sensitive
                // DaysOfTheWeek is the DATA TYPE here so when making a variable 'week' we must state that, and we are setting 
                //line 21 of the code is basically converint string to enum so it can be seen by the newly creating variable 'weekday'
                //
                Console.WriteLine("You chose " + weekday + " as the day of the week.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            
            Console.Read();

        }
        public enum DaysOfTheWeek //creating enum
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

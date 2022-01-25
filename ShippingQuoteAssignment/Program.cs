using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please Follow the instructions below.\nWhat is your package weight?:");
            string packageWeight = Console.ReadLine();
            int packWeight = Convert.ToInt32(packageWeight);
            if (packWeight > 50) //if package weights more than 50, end program
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else //if package weighs less than 50, continue
            {
                Console.WriteLine("Package width:");
                string packageWidth = Console.ReadLine();
                int packWidth = Convert.ToInt32(packageWidth);
                Console.WriteLine("Package height:");
                string packageHeight = Console.ReadLine();
                int packHeight = Convert.ToInt32(packageHeight);
                Console.WriteLine("Package length:");
                string packageLength = Console.ReadLine();
                int packLength = Convert.ToInt32(packageLength);
                if (packWidth + packHeight + packLength > 50) //if package adds up to more than 50, stop program
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else //if package does not add to more than 50, continue 
                {
                    decimal totalSize = ((packWidth * packHeight * packLength) * packWeight) / 100;
                    Console.WriteLine("Your quote is: $" + totalSize + ".00");
                    Console.ReadLine(); 
                }
            }
        }
    }
}

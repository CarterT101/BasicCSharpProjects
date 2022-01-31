using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 10, 4, 6, 12, 8, 2 };
            List<double> answerList = new List<double>();
            foreach (int n in numberList)
            {
                Console.WriteLine(n);
            }
            bool done = false;
            
            while (!done) //makes sure if catch block catches something it will ask for the user input again in the try block so the program doesn't end until complete
            {

                try
                {
                    Console.WriteLine("Entering try block");

                    Console.WriteLine("Input a number to divide each number in the list by");
                    double yourNumber = Convert.ToDouble(Console.ReadLine());

                    if (yourNumber != 0) //makes sure number is not divided by zero
                    {
                        foreach (int n in numberList)
                        {
                            double answer = (n / yourNumber);
                            answerList.Add(answer);
                        }
                        Console.WriteLine("Here are your answers");
                        foreach (double a in answerList)
                        {
                            Console.WriteLine(a);
                        }
                        done = true;
                    }
                    else if (yourNumber == 0) //since the double data type allows division by zero the catch (dividebyzeroexception) does not work so this is necessary
                    {
                        Console.WriteLine("Please don't divide by zero");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a number");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine("Exiting try/catch block");

            Console.Read();
        }
    }
}

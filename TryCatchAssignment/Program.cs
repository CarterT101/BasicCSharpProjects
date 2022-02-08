using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int yourAge = 1;
            while (!validAnswer)
            {
                try
                {
                    Console.WriteLine("What is your age");
                    validAnswer = int.TryParse(Console.ReadLine(), out yourAge);
                    if (yourAge <= 0)
                    {
                        Console.Write("Impossible");
                        Console.Read();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter valid age");
                    Console.Read();
                    return;
                }

            }
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime yourDate = today.AddYears(-yourAge);
            Console.WriteLine("You were born in {0}", yourDate);
            Console.Read();
        }
    }
}

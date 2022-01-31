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
            List<int> numberList = new List<int>() { 10, 4, 6, 9, 7, 3 };
            foreach (int n in numberList)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Input a number to divide each number in the list by");
            int yourNumber = Convert.ToInt32(Console.ReadLine());

            Console.Read();
        }
    }
}

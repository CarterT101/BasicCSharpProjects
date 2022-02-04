using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1; //instance

            num1.Amount = 5; //assigning value

            Console.WriteLine(num1.Amount); //printing value
            Console.Read();

        }
        public struct Number //creating struct
        {
            public decimal Amount; //creating property
        }
    }
}

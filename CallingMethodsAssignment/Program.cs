using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Integers add = new Integers();

            Console.WriteLine("Input a number to add 10 to it");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            int result = add.Add(yourNum); //instance of Integers called add, passed in number 
            Console.WriteLine(result);


            Console.WriteLine("Input a number to subtract 5 from it");
            int subNum = Convert.ToInt32(Console.ReadLine());
            result = add.Subtract(subNum);
            Console.WriteLine(result);


            Console.WriteLine("Input a number to be multiplied by 3");
            int multNum = Convert.ToInt32(Console.ReadLine());
            result = add.Multiply(multNum);
            Console.WriteLine(result);







            Console.Read();

        }
    }
}

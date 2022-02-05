using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            string yourNum = Console.ReadLine();

            File.WriteAllText(@"C:\Users\hoove\Documents\test.txt", yourNum);
            Console.WriteLine("You chose {0}", yourNum);
            Console.Read();
        }
    }
}

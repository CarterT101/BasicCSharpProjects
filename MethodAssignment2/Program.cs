using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = new Operation();

            oper.Multi(10, 5);
            oper.Multi(mult1: 10, mult: 4);
            Console.Read();

        }
    }
}

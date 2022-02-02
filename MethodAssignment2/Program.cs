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

            int result = oper.Multi(10, 5);

            result = oper.Multi(mult: 10, mult1: 5);
        }
    }
}

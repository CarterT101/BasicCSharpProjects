using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Operation
    {
        public int Multi(int mult, int mult1 = 5) //setting default value to 5 if not chosen
        {
            return mult * mult1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Operation
    {
        public int Multi(int mult) //int
        {
            return mult * 3;
        }

        public int Multi(decimal mult) //can input decimals
        {
            int result = Convert.ToInt32(mult);
            return result * 3;
        }

        public int Multi(string mult) //can input string
        {
            int result = Convert.ToInt32(mult);
            return result * 3;
        }

    }
}

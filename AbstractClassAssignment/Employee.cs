using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person //inherit
    {
        public override void SayName() //implement SayName method
        {
            Console.WriteLine(firstName + " " + lastName); //making method useful
        }
    }
}

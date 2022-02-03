using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable //inherit
    {
        public override void SayName() //implement SayName method
        {
            Console.WriteLine(firstName + " " + lastName); //making method useful
        }
        public void Quit()
        {
            Console.WriteLine("This is a quit method");
        }

    }
}

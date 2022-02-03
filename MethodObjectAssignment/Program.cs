using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee(); //instance of inherited class

            empl.FirstName = "Sample";
            empl.LastName = "Student";

            empl.SayName(); //superclass method

            Console.Read();

        }
    }
}

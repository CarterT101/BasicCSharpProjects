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
            Employee empl = new Employee();

            empl.FirstName = "Sample";
            empl.LastName = "Student";

            empl.SayName();

            Console.Read();

        }
    }
}

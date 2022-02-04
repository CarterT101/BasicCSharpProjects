using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> empl = new Employee<string>();
            empl.things = "Hello";

            Console.WriteLine(empl);
            Console.Read();
        }
    }
}

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
            
            Employee<int> empl1 = new Employee<int>();
            empl1.things = 5;

            Console.WriteLine(empl.things + " " + empl1.things);
            Console.Read();
        }
    }
}

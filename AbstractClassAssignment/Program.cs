using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instance
            employee.firstName = "Sample"; //giving values
            employee.lastName = "Student";

            employee.SayName(); //calling method
            Console.Read();
        }
    }
}

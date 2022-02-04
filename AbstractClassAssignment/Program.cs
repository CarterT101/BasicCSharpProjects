using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Program : Employee
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee(); //instance
            //employee.firstName = "Sample"; //giving values
            //employee.lastName = "Student";

            //employee.SayName(); //calling method

            IQuittable quit = new Employee();
            quit.Quit(); 

            Console.Read();
        }
    }
}

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
            Employee empl1 = new Employee();

            empl.FirstName = "Sample";
            empl.LastName = "Student";
            empl.Id = 1;

            empl1.FirstName = "Sample1";
            empl1.LastName = "Student1";
            empl1.Id = 2;

            //empl.SayName(); //superclass method

            if (empl == empl1)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }


            Console.Read();

        }
    }
}

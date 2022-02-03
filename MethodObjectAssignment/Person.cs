using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectAssignment
{
    class Person
    {
        public string FirstName { get; set; } //property data type string
        public string LastName { get; set; }

        public void SayName() //method 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}

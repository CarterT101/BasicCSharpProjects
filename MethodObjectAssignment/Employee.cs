using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectAssignment
{
    class Employee : Person //instance
    {
        public int Id { get; set; } //new property

        public static bool operator == (Person person, Employee employee)
        {
            bool answer = person == employee; //setting bool variable to check if person == employee id
            return answer;
        }

        public static bool operator != (Person person, Employee employee) //if == is to be overloaded != should also be overloaded.
        {
            bool answer = person == employee;
            return answer;
        }

        public override bool Equals(object obj) //these are required for overloading previous two bool operator overloading
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

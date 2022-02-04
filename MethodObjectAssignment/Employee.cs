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

        public static bool operator == (Employee empl, Employee empl1)
        {
            return empl.Id == empl1.Id;
        }

        public static bool operator != (Employee empl, Employee empl1) //if == is to be overloaded != should also be overloaded.
        {
            return empl.Id == empl1.Id;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string greet = "Hello"; //creating constant

            var name = "Carter"; //assigning implicit variable           
             
            

            Console.WriteLine(greet + " " + name); //concatenating together

            Console.Read();
        }
        public class myClass
        {
            string name = "Rick";
            public myClass() : this("Carter")
            {
            }
            public myClass(string name)
            {
                this.name = name;
            }

            myClass test = new myClass("Carter");
        }
        
    }
}

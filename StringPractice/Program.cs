using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello, my name is ";
            string name = "Carter, and I ";
            string sentence = "like software development.";
            string sentenceUpper = sentence.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append(hello + name + sentenceUpper);
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}

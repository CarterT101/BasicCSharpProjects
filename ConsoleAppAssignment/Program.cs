using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[5];
            stringArray[0] = "Hello there, ";
            stringArray[1] = "Your name is ";
            stringArray[2] = "This person is cool: ";
            stringArray[3] = "Great job, ";
            stringArray[4] = "You are my friend, ";

            Console.WriteLine("Write your name:");
            string yourName = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + yourName;
                Console.WriteLine(stringArray[i]);
            }

            bool isGuessed = false;

            while (!isGuessed)
            {
                Console.WriteLine("\nHello");
                isGuessed = true; //get rid of this to make infinite loop
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("Hello, " + yourName);
                j++;
            }

            int f = 0;
            while (f <= 10)
            {
                Console.WriteLine(f);
                f++;
            }

            List<string> stringList = new List<string>() { "This ", "is ", "a ", "string ", "list." };

            foreach (string i in stringList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Input text to find in list");
            string stringChoice = Console.ReadLine();
            
                for (int k = 0; k < stringList.Count; k++)
                {
                    if (stringList[k] == stringChoice)
                    {
                        Console.WriteLine("Found it at index: " + k);
                        
                    }
                    else
                    {
                        Console.WriteLine("Did not find, try again:");
                    }
                }
 
            
            
            


            Console.Read();
        }
    }
}

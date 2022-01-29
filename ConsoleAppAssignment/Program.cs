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

            ////Part 1
            //string[] stringArray = new string[5];
            //stringArray[0] = "Hello there, ";
            //stringArray[1] = "Your name is ";
            //stringArray[2] = "This person is cool: ";
            //stringArray[3] = "Great job, ";
            //stringArray[4] = "You are my friend, ";

            //Console.WriteLine("Write your name:");
            //string yourName = Console.ReadLine();

            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    stringArray[i] = stringArray[i] + yourName;
            //    Console.WriteLine(stringArray[i]);
            //}

            ////part 2

            //bool isGuessed = false;

            //while (!isGuessed)
            //{
            //    Console.WriteLine("\nHello");
            //    isGuessed = true; //get rid of this to make infinite loop
            //}

            ////part 3 

            //int j = 0;
            //while (j < 5)
            //{
            //    Console.WriteLine("Hello, " + yourName);
            //    j++;
            //}

            //int f = 0;
            //while (f <= 10)
            //{
            //    Console.WriteLine(f);
            //    f++;
            //}

            ////part 4 

            //List<string> stringList1 = new List<string>() { "This", "is", "a", "string", "list" };

            //foreach (string i in stringList1)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Input text to find in list");
            //string stringChoice1 = Console.ReadLine();
            //bool found1 = false;

            //for (int k = 0; k < stringList1.Count; k++)
            //{
            //    if (stringList1[k] == stringChoice1)
            //    {
            //        Console.WriteLine("Found it at index: " + k);
            //        found1 = true;
            //        break;
            //    }
            //}

            //if (!found1)
            //{
            //    Console.WriteLine(stringChoice1 + " was not found");
            //}

            ////part 5

            //List<string> stringList = new List<string>() { "This", "is", "a", "string", "list", "string" };

            //foreach (string i in stringList)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Input text to find in list");
            //string stringChoice = Console.ReadLine();
            //bool found = false;
            
            //for (int k = 0; k < stringList.Count; k++)
            //{
            //    if (stringList[k] == stringChoice)
            //    {
            //        Console.WriteLine("Found it at index: " + k);
            //        found = true;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine(stringChoice + " was not found");
            //}

            //part 6

            List<string> stringList3 = new List<string>() { "Computers", "Computers", "are", "very", "very", "cool" };
            List<string> checkList = new List<string>();

            checkList = stringList3.Distinct().ToList();

            foreach (string s in checkList)
            {
                for(int i = 0; i < stringList3.Count; i++)
                {
                    if (stringList3[i] == s)
                    {
                        Console.WriteLine("\"" + stringList3[i] + "\"" + " is already in the list");
                    }
                }
                Console.WriteLine(s);
            }

            
            Console.Read();
        }
    }
}

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

            //Part 1
            string[] stringArray = new string[5]; //make string array
            stringArray[0] = "Hello there, ";
            stringArray[1] = "Your name is "; //add to array
            stringArray[2] = "This person is cool: ";
            stringArray[3] = "Great job, ";
            stringArray[4] = "You are my friend, ";

            Console.WriteLine("Write your name:");
            string yourName = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++) //for every item in the array, concatinate a string from the user input and item in list
            {
                stringArray[i] = stringArray[i] + yourName;
                Console.WriteLine(stringArray[i]);
            }

            //part 2

            bool isGuessed = false;

            while (!isGuessed) //while isGuessed is false, print 'Hello', which gets stopped by selling isGuessed to true after the first time around the while loop
            {
                Console.WriteLine("\nHello");
                isGuessed = true; //get rid of this to make infinite loop
            }

            //part 3 

            int j = 0;
            while (j < 5) //while iteration j is less than 5, print hello 'variable' to the console
            {
                Console.WriteLine("Hello, " + yourName);
                j++;
            }

            int f = 0; 
            while (f <= 10) //counts to 10 by making a while loop that prints until iteration f is less than or equal to 10
            {
                Console.WriteLine(f);
                f++;
            }

            //part 4 

            List<string> stringList1 = new List<string>() { "This", "is", "a", "string", "list" }; //making a list with all unique items that will be iterated through 

            foreach (string i in stringList1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Input text to find in list"); //a user can find an item in the string listed above in the console 
            string stringChoice1 = Console.ReadLine();      // by searching for it and it will print the index number
            bool found1 = false;

            for (int k = 0; k < stringList1.Count; k++)
            {
                if (stringList1[k] == stringChoice1)
                {
                    Console.WriteLine("Found it at index: " + k);
                    found1 = true;
                    break;
                }
            }

            if (!found1)
            {
                Console.WriteLine(stringChoice1 + " was not found");
            }

            //part 5

            List<string> stringList = new List<string>() { "This", "is", "a", "string", "list", "string" }; //makes a list with duplicate items and will find that item
                                                                                                            // at both index spots
            foreach (string i in stringList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Input text to find in list");
            string stringChoice = Console.ReadLine();
            bool found = false;

            for (int k = 0; k < stringList.Count; k++)
            {
                if (stringList[k] == stringChoice)
                {
                    Console.WriteLine("Found it at index: " + k);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(stringChoice + " was not found");
            }

            //part 6

            List<string> stringList3 = new List<string>() { "Computers", "Computers", "are", "very", "very", "cool" }; 
            List<string> checkList = new List<string>();                //list with duplicates and creating a new list that will help get rid of the duplicates in previous list
             

            foreach (string s in stringList3) //for every item in stringList3, 
            {
                if (checkList.Contains(s))  //check if the second list contains it, if it does contain said item, print something to the console
                {
                    Console.WriteLine("The item " + s + " has appeared before.");
                }
                else //if it is a new item, add it to the new list.
                {
                    checkList.Add(s);
                }
                
            }

            foreach (string s in checkList) //iterates through list to print all the items to console
            {
                Console.WriteLine(s);
            }
            
            Console.Read();
        }
    }
}

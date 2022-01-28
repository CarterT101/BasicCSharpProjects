using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movieList = new string[4]; //creating new string array
            movieList[0] = "Spider-Man";
            movieList[1] = "Batman";
            movieList[2] = "Free Guy";
            movieList[3] = "Ocean's 8";

            Console.WriteLine("What movie do you like more? ");
            for (int i = 0; i < movieList.Length; i++) //setting up for loop to list all the movies they can choose
            {
                Console.WriteLine(movieList[i]);
            }

            Console.WriteLine("Input number 0-3");
            int yourNum = Convert.ToInt32(Console.ReadLine()); //converting their string answer to int
            bool correctNum = false; //setting bool to false to help the while loop work

            while (!correctNum) //while correctNum = false, do this
            {
                if (-1 < yourNum && yourNum < 4) //if yourNum is within the index guidelines, do the next step
                {
                    Console.WriteLine("Your favorite movie is: " + movieList[yourNum]); //tells them the movie they chose from the index
                    correctNum = true;
                    

                }
                else
                {
                    Console.WriteLine("Please choose a number 0-3"); //makes sure they choose the correct number from index
                    yourNum = Convert.ToInt32(Console.ReadLine());
                    
                }
            }




            int[] intArray = new int[4];
            intArray[0] = 5;
            intArray[1] = 300;
            intArray[2] = 375;
            intArray[3] = 19823;

            Console.WriteLine("Choose a number 0-3");
            int yourChoice = Convert.ToInt32(Console.ReadLine());
            bool guessedCorrect = false;

            while (!guessedCorrect)
            {
                if (-1 < yourChoice && yourChoice < 4)
                {
                    Console.WriteLine("You chose the number " + intArray[yourChoice]);
                    guessedCorrect = true;
                }
                else
                {
                    Console.WriteLine("Please choose a number 0-3");
                    yourChoice = Convert.ToInt32(Console.ReadLine());
                }
            }

            List<string> stringList = new List<string>(); //creates string list 
            stringList.Add("Hello");
            stringList.Add("There");
            stringList.Add("General Kenobi");
            stringList.Add("Ahhh");

            Console.WriteLine("Want a string? Pick a number 0-3");
            int theirChoice = Convert.ToInt32(Console.ReadLine());
            bool stringGuessed = false;

            while (!stringGuessed)
            {
                if (-1 < theirChoice && theirChoice < 4)
                {
                    Console.WriteLine(stringList[theirChoice]);
                    stringGuessed = true;
                }
                else
                {
                    Console.Write("Please choose a number 0-3 for a cool string");
                    theirChoice = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.Read();
        }
    }
}

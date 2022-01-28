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
            string[] movieList = new string[4];
            movieList[0] = "Spider-Man";
            movieList[1] = "Batman";
            movieList[2] = "Free Guy";
            movieList[3] = "Ocean's 8";

            Console.WriteLine("What movie do you like more? ");
            for (int i = 0; i < movieList.Length; i++)
            {
                Console.WriteLine(movieList[i]);
            }

            Console.WriteLine("Input number 0-3");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            bool correctNum = false;

            while (!correctNum)
            {
                if (-1 < yourNum && yourNum < 4)
                {
                    Console.WriteLine("Your favorite movie is: " + movieList[yourNum]);
                    correctNum = true;
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Please choose a number 0-3");
                    yourNum = Convert.ToInt32(Console.ReadLine());
                    break;
                }
            }
            
            
            

            //int[] intArray = new int[4];
            //intArray[0] = 5;
            //intArray[1] = 300;
            //intArray[2] = 375;
            //intArray[3] = 19823;

            //Console.WriteLine("Choose a number 0-3");
            //int yourChoice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You chose the number " + intArray[yourChoice]);


            Console.Read();
        }
    }
}

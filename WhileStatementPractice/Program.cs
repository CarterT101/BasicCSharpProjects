using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatementPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting down from 10");
            int i = 10;

            do
            {
                Console.WriteLine(i);
                i--;
            } while (i > 0);
            
            bool isGuessed = false;
            Console.WriteLine("Pick a number 1-10:");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            while (isGuessed == false)
            {
                switch (yourNum)
                {
                    case 6:
                        isGuessed = true;
                        Console.WriteLine("You guessed 6, which is correct!");
                        break;
                    default:
                        isGuessed = false;
                        Console.WriteLine("You guessed wrong, try again");
                        Console.WriteLine("Pick a number 1-10:");
                        yourNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();


        }
    }
}

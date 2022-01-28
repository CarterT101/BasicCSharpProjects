using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 75, 44, 23, 78, 65, 56, 87 };

            //for(int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 70)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }



            //}


            //string[] names = { "Jesse", "Erik", "James", "Kenn", "Evan" };

            //for(int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //List<int> testScores2 = new List<int>();
            //testScores2.Add(98);
            //testScores2.Add(78);
            //testScores2.Add(87);
            //testScores2.Add(69);
            //testScores2.Add(89);
            //testScores2.Add(76);

            //foreach (int score in testScores2) //score is variable name, aka i for the iteration
            //{
            //    if (score > 80)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);

            Console.Read();
        }
    }
}

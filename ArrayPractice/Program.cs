using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 500, 2300 };

            int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            numArray2[5] = 650;

            Console.WriteLine(numArray1[3]);

            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);

            //List<string> stringList = new List<string>();
            //stringList.Add("Hello");
            //stringList.Add("World");

            //Console.WriteLine(stringList[1]);


            Console.Read();

        }
    }
}

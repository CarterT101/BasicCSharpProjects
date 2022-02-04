using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> employeeList = new List<string>(); //new list for first name
            List<int> idList = new List<int>(); //new list for id

            Employees empl1; //creating employee with structure list, assigning first, last name, and id for 10 different employees
            empl1.firstName = "Bob";
            empl1.lastName = "J";
            empl1.Id = 1;

            employeeList.Add(empl1.firstName); //adding first name to new list
            idList.Add(empl1.Id); //adding id to new id list

            Employees empl2;
            empl2.firstName = "Joe";
            empl2.lastName = "S";
            empl2.Id = 2;

            employeeList.Add(empl2.firstName);
            idList.Add(empl2.Id);

            Employees empl3;
            empl3.firstName = "Joe";
            empl3.lastName = "F";
            empl3.Id = 3;

            employeeList.Add(empl3.firstName);
            idList.Add(empl3.Id);

            Employees empl4;
            empl4.firstName = "Sheryl";
            empl4.lastName = "G";
            empl4.Id = 4;

            employeeList.Add(empl4.firstName);
            idList.Add(empl4.Id);

            Employees empl5;
            empl5.firstName = "John";
            empl5.lastName = "K";
            empl5.Id = 5;

            employeeList.Add(empl5.firstName);
            idList.Add(empl5.Id);

            Employees empl6;
            empl6.firstName = "Brandon";
            empl6.lastName = "M";
            empl6.Id = 6;

            employeeList.Add(empl6.firstName);
            idList.Add(empl6.Id);

            Employees empl7;
            empl7.firstName = "Evan";
            empl7.lastName = "W";
            empl7.Id = 7;

            employeeList.Add(empl7.firstName);
            idList.Add(empl7.Id);

            Employees empl8;
            empl8.firstName = "Gerald";
            empl8.lastName = "J";
            empl8.Id = 8;

            employeeList.Add(empl8.firstName);
            idList.Add(empl8.Id);

            Employees empl9;
            empl9.firstName = "Flo";
            empl9.lastName = "O";
            empl9.Id = 9;

            employeeList.Add(empl9.firstName);
            idList.Add(empl9.Id);

            Employees empl10;
            empl10.firstName = "Rick";
            empl10.lastName = "U";
            empl10.Id = 10;

            employeeList.Add(empl10.firstName);
            idList.Add(empl10.Id);

            List<string> newList = new List<string>(); //creating new list to add specific names (joe) to list

            foreach (string emp in employeeList) //for each employee, check if joe is a name and if it is, add it to new list
            {
                if (emp == "Joe")
                {
                    newList.Add(emp);
                }
            }

            List<string> joeList = employeeList.Where(x => x == "Joe").ToList(); //same thing as above foreach loop, except in lambda

            foreach (string l in joeList)
            {
                Console.WriteLine(l); //printing each item in new joeList
            }

            List<int> newIdList = idList.Where(x => x > 5).ToList(); //making new list for id where each id is checked and added to new list if greater than 5

            foreach (int i in newIdList)
            {
                Console.WriteLine(i); //printing each item in list
            }

            Console.Read();
        }
        
        public struct Employees
        {
            public string firstName;
            public string lastName;
            public int Id;
        }
    }
}


using System;

namespace StudentAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            using (var db = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Carter" };
                db.Students.Add(stud);
                db.SaveChanges();
            }
            Console.Read();
        }
    }
}

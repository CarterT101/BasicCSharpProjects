using System;
using System.Collections.Generic;
using System.Text;

namespace FinalStudentsAssignment
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Grade Grade { get; set; }
    }
}

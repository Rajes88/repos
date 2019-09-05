using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLists
{
    class students
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Enrolled { get; private set; }

        static void Main(string[] args)
        {
            // List using custom type (class)
            List<students> myStudents = new List<students>();

            students objStudent = new students();

            objStudent.FirstName = "John";
            objStudent.LastName = "Doe";
            objStudent.Enrolled= "Yes";

            myStudents.Add(objStudent);

            

        }
    }
}

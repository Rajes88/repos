using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6employee
{
    class employee
    {
        string firstName;
        string lastName;
        string dept;

        public employee(string firstName, string lastName, string dept)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dept = dept;

            if (string.IsNullOrEmpty(dept))
            {
                dept = "IT";

            }
            Console.WriteLine("FirstName:" + firstName + "lastName:" + lastName + " department:" + dept);




            }
        }
    }
    


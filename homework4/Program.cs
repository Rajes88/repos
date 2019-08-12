using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci series!");
            int firstNum, secondNum, thirdNum, term;
            firstNum = 1;
            secondNum = 1;
            Console.Write("Enter the term:");
            term = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstNum + "   " + secondNum);
            for (int i = 3; i <= term; i++)
            {
                thirdNum = firstNum + secondNum;
                Console.Write("   " + thirdNum);
                firstNum = secondNum;
                secondNum = thirdNum;
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace ConsoleAppInheritanceAndPoly
{
    /// <summary>
    /// 
    /// parent class
    /// </summary>
    abstract class account
    {
        class Program
        {
            static void Main(string[] args)
            {
                CheckingAccount myChkAccount = new CheckingAccount(1000);
                myChkAccoun.(250);
                Console.ReadLine();
                Console.WriteLine("Initiate withdrawl of $ 250");
                myChkAccount.Withdrawl(250);
                Console.WriteLine(" Balance is : $" + myChkAccount.Balance);

                Console.ReadLine();
                Console.WriteLine("Initiate withdrawl of $850");
                myChkAccount.Withdrawl(850);
                Console.WriteLine("Balance is : $ + mychkAcccount.Balance");

                Console.ReadLine();
            }

            // child clsass can implement its own withdrawl method with custom logic

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritanceAndPoly

/// Inherited from Account Class, Child class checking Account
/// <summary>
{
    abstract class  Account
    {
        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }

        // set our account balance, initial balance value using constructor
        public Account(decimal initialBalance)
        {
            Balance = initialBalance;

        }
        public void deposit(decimal amount)

        {
            Balance += amount;
        }

        // child class can implemment jits own withdrawl method with custom logic
        public abstract transaction (decimal amount)
        {
        }



        
    }
}


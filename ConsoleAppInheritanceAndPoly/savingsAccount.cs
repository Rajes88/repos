using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritanceAndPoly
{
    class savingsAccount : Account

    {

        private const int MONTHLY_WITHDRAWL_LIMIT = 5;
        public decimal InterestRate { get; set; }
        public int withdrawsThisMonth { get; set; }

        // set the initial Balance 
        public savingsAccount(decimal initialBalance, int withdrawlsThisMonth) :base(initialBalance)
            
        {
            withdrawsThisMonth = withdrawlsThisMonth;

        }
        public override transaction withdrawl(decimal amount)
        {

        }
            public void ProcessProfit()
        {
            Balance += Balance * InterestRate;

            // Implement the withdrawl transaction logic here

            transaction thisTransaction = new transaction();
            thisTransaction.AccountNumbert = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.TimeStamp = DateTime.Now;
            thisTransaction.isSuccessful = false;

            //perform withdrawl

            if (amount > Balance)

            {
                thisTransaction.Detail = "Transaction failed, Insufficient Balance. $ " + Balance;
                Console.WriteLine("Transaction Failed, Insufficient Balance.");

            }

            else if (WithdrawlsThisMonth > MONTHLY_WITHDRAWL_LIMIT)
            {
                thisTransaction.Detail = "Transaction Failed, due to monthly withdrawl limit");
            }
            else
            {
                Balance += amount;
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = "Debit Transaction for account number" + AccountNumber + "With the amount of $" + amount;
                Console.WriteLine("thisTransaction.Detail");

            }

            return thisTransaction;



        }
    }
}

    
    
    


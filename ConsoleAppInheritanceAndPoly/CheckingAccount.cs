using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritanceAndPoly
{
    class CheckingAccount: Account
    {
        public CheckingAccount (decimal intialBalance) :base(intialBalance)
        {

        }
        public  override transaction withdral(decimal amount)

        {
            //Create Transaction object
            transaction thisTransaction = new transaction();
            thisTransaction.AccountNumbert = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.isSuccessful = false;
            thisTransaction.TimeStamp = DateTime.Now;


            //try to process transaction
            if (amount > Balance)
            {
               thisTransaction.Detail = "Transaction Failed: Insufficient Funds.";
                Console.WriteLine("Trasactioin Failed: Insufficient Funds.");
            }
            else
            {
                Balance -= amount;  // Balance = Balance - amount;
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = string.Format("Account#: {0} was debited {1}", thisTransaction.AccountNumbert, thisTransaction.Amount);
                Console.WriteLine("Successfully withdrew from "+ thisTransaction.AccountNumber + " debited amount of" + thisTransaction.Amount);

                
                    
            }

            return thisTransaction;

        }
    }

}

                

    


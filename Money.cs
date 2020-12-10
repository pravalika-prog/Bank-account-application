using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Money
    {
        static void Main()
        {
            double  Newbalance;
            string balance;
            Account ac = new Account();
            Console.WriteLine("your current balance is 500 ");
            Console.WriteLine("press d for deposit,press w for withdrwal ");
            balance = Console.ReadLine();
            if (balance == "d")
            {
                Newbalance = ac.deposit();
                Console.WriteLine( "you are balance is:{0}", Newbalance);
            }
           else if(balance== "w")
            {
                Newbalance = ac.Withdrawl();
                Console.WriteLine("you are balance is:{0}", Newbalance);
                    
                    
            }

        }
    }
}

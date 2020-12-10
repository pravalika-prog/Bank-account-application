using System;

namespace BankAccount
{
 public   class Account
    {
        public double balance;
        public Account()
        {
            balance = 500;
        }
        public double deposit()
        {
            double Newbalance;
            double deposit;
            Console.WriteLine("enter the amaount to deposit");
            deposit = double.Parse(Console.ReadLine());
            Newbalance = balance + deposit;
            return Newbalance;
        }
        public double Withdrawl()
        {
            double Newbalance;
            double Withdrawl;
            Console.WriteLine("enter the amaount to withdrawl");
            Withdrawl = double.Parse(Console.ReadLine());
            Newbalance = balance - Withdrawl;
            return Newbalance;
        }
    }
}
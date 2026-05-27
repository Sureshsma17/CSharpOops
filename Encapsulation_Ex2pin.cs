using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class Account
    {
        private double balance;
        private int pin=1234;
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }

        }
        public void Withdraw(double amount,int enterpin)
        {
            if (enterpin == pin)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN. Access denied.");
            }

        }
        public double GetBalance()
        {
            
            return balance;

        }
    }
        internal class Encapsulation_Ex2pin
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.Deposit(5000);
            acc.Withdraw(2000,123);
            acc.GetBalance();
            Console.WriteLine("Balance: " + acc.GetBalance());
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class BankAccount
//    {
//        private double balance;
//        private string pin;

//        public double Balance
//        {
//            get { return balance; }
//            set { 
//                if(value>=0) 
//                balance = value; }
//        }
//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//            }
//        }
//        public void Withdraw(double amount, string enteredpin)
//        {
//            if (enteredpin == pin && amount <= Balance)
//            {
//                Balance -= amount;
//            }
//        }
//        public BankAccount(double initialBalance, string accountpin)
//        {
//            Balance = initialBalance;
//            pin = accountpin;
//        }
//        internal class Encaspulation_BankExample
//        {
//            static void Main(string[] args)
//            {
//                BankAccount acc = new BankAccount(10000, "1234");
//                acc.Deposit(5000);
//                acc.Withdraw(2000,"1234");
//                acc.Withdraw(2000, "9999");
//                Console.WriteLine("Final Balance is: " + acc.Balance);
//            }
//        }
//    }
//}

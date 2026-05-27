//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Account
//    {
//        private double balance;
//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//            }
            
//        }
//        public void Withdraw(double amount)
//        {
//            if (amount<=balance)
//            {
//                balance -= amount;
//            }
            
//        }
//        public double GetBalance()
//        {
//            return balance;
//        }
//    }
//    internal class Encapsulation_Example
//    {
//        static void Main(string[] args)
//        {
//            Account acc = new Account();
//            acc.Deposit(5000);
//            acc.Withdraw(2000);
//            Console.WriteLine("Balance: " + acc.GetBalance());
//        }
//    }
//}

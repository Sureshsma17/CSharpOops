//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class BankAccount
//    {
//        public int Accountnum;
//        public double Balance;
//        public static string Bankname = "ICICI";

//        public void Deposit(double amount)
//        {
//            Balance +=amount; 
//            Console.WriteLine("Deposit amount:"+Balance);
//        }

//        public void Withdraw(double amount)
//        { 
//            Balance -=amount; 
//        Console.WriteLine("Withdraw balance:"+Balance);
//        }
//        public void Display()
//        {
//            Console.WriteLine("The Bank Name is: "+ Bankname);

//        }
//    }
//    internal class BankAccount_Task1
//    {
//        static void Main(string[] args)
//        {
//            BankAccount account = new BankAccount();
//            account.Deposit(10000);
//            account.Withdraw(5000);
//            account.Display();
//            Console.WriteLine("Final Balance is: " + account.Balance);
//        }
//    }
//}

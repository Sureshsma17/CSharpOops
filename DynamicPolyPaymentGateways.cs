//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    abstract class Payment
//    {
//        public abstract void PaymentProcess(double amount);
//        public virtual void ShowInfo()
//        {
//            Console.WriteLine($"General Payment");
//        }
//    }

//    class CreditCardPayment : Payment//This is a concrete class which is inheriting the abstract class Payment
//    {
//        public override void PaymentProcess(double amount) //This method is overriding the abstract method in the base class
//        {
//            Console.WriteLine($"Processing CreditCard Payment {amount}");
//        }
//        public override void ShowInfo() //This method is overriding the virtual method in the base class
//        {
//            Console.WriteLine($"Payment done through CredtCard");
//        }
//    }

//    class UPI : Payment //This is a concrete class which is inheriting the abstract class Payment
//    {
//        public override void PaymentProcess(double amount) //This method is overriding the abstract method in the base class
//        {
//            Console.WriteLine($"Processing UPI Payment {amount}");
//        }
//        public override void ShowInfo() //This method is overriding the virtual method in the base class
//        {
//            Console.WriteLine($"Payment done through UPI");
//        }
//    }

//    internal class DynamicPolyPaymentGateways
//    {
//        static void Main(string[] args)
//        {
//            Payment p = new CreditCardPayment(); //This is a reference of the base class which is referring to the object of the derived class
//            p.PaymentProcess(15000); //This is a dynamic polymorphism because the method which is called is decided at runtime
//            p.ShowInfo(); //This is a dynamic polymorphism because the method which is called is decided at runtime

//            Payment upi = new UPI(); //This is a reference of the base class which is referring to the object of the derived class
//            upi.PaymentProcess(400); //This is a dynamic polymorphism because the method which is called is decided at runtime
//            upi.ShowInfo(); //This is a dynamic polymorphism because the method which is called is decided at runtime
//        }

//    }
//}

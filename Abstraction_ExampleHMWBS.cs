//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{

//    abstract class HMWBS
//    {
//        public void BillDetails()
//        {
//            Console.WriteLine("HMWBS bill Generated");
//        }
//        public abstract void GetBill(double units);
//    }

//    class ResidentialCustomers : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 7;
//            Console.WriteLine("Residential Customers bill is: " + bill);
//        }
        
//    }

//    class CommercialCustomers:HMWBS
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 10;
//            Console.WriteLine("Commercial Customers bill: " + bill);
//        }
//    }

//    class IndustryCustomers:HMWBS
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 15;
//            Console.WriteLine("Industry Customers Bill: " + bill);
//        }
//    }

//    class AgericultureCustomers : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 0;
//            Console.WriteLine("Agriculture Customers Boll: " + bill);
//        }
//    }
//    internal class Abstraction_ExampleHMWBS
//    {
//        static void Main(string[] args)
//        {
//            HMWBS obj = new ResidentialCustomers();
//            obj.BillDetails();
//            Console.WriteLine("Enter no.of units Consumed");

//            double unit=Convert.ToDouble(Console.ReadLine());
//            obj.GetBill(unit);

//            obj=new CommercialCustomers();
//            obj.GetBill(unit);

//            obj= new IndustryCustomers();
//            obj.GetBill(unit);

//            obj=new AgericultureCustomers();
//            obj.GetBill(unit);
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    abstract class ElectricityBill
//    {
//        public void BillDeatails()
//        {
//            Console.WriteLine("Electricity Bill Generated");
//        }
//        public abstract void GetBill(double units);
//    }

//    class ResidentialCustomers : ElectricityBill
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 4;
//            Console.WriteLine("ResidentialCustomers bill is: " + bill);
//        }
//    }

//    class CommercialCustomers : ElectricityBill
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 10;
//            Console.WriteLine("CommercialCustomers bill is: " + bill);
//        }
//    }

//    class IndustrialCustomers : ElectricityBill
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 20;
//            Console.WriteLine("IndustrialCustomers bill is: " + bill);
//        }
//    }


//    internal class Abstraction_ExampleElectricityBill
//    {
//        static void Main(string[] args)
//        {
//            ElectricityBill EB = new ResidentialCustomers();
//            EB.BillDeatails();
//            Console.WriteLine("Enter No. of units Consumed");

//            double unit = Convert.ToDouble(Console.ReadLine());
//            EB.GetBill(unit);

//            EB = new CommercialCustomers();
//            EB.GetBill(unit);

//            EB = new IndustrialCustomers();
//            EB.GetBill(unit);

//        }
//    }
//}

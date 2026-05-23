//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Reports
//    {
//        public void GetReports()//This class is doing more than one responsibility, which is against the Single Responsibility
//                                //Principle (SRP) of SOLID principles.
//                                //It should be refactored into separate classes for each responsibility.

//        {
//            Console.WriteLine("Reports Content");
//        }
//        public void PrintReports()
//        {
//            Console.WriteLine("Prints Printed");
//        }
//        public void BillReports()
//        {
//            Console.WriteLine("Bill Genereated");
//        }
//    }

//    class GetReports
//    {
//        public void GetReport()
//        {
//            Console.WriteLine("Reports Content");//This class is responsible for fetching or generating reports, adhering to the Single Responsibility Principle (SRP).
//        }
//    }

//    class PrintReports
//    {
//        public void BillReports()
//        {
//            Console.WriteLine("Print Content");
//        }
//        public void MSWord()
//        {
//            Console.WriteLine("Ms Word Documents");//This class is responsible for printing reports in different formats, adhering to the Single Responsibility Principle (SRP).
//        }
//        public void PDFPrint()
//        {
//            Console.WriteLine("PDF Print");//This class is responsible for printing reports in different formats, adhering to the Single Responsibility Principle (SRP).
//        }
//    }

//    class BillReports
//    {
//        public void BillReport()
//        {
//            Console.WriteLine("Bill Generated");//This class is responsible for generating bills, adhering to the Single Responsibility Principle (SRP).
//        }
//    }

//    internal class SOLIDPrincipleClassExample
//    {
//        static void Main(string[] args)
//        {
//            Reports r = new Reports();
//            r.GetReports(); // This violates the Single Responsibility Principle (SRP) because the Reports class is responsible for multiple tasks: fetching reports, printing reports, and generating bills. Each of these tasks should ideally be handled by separate classes to adhere to SRP.
//            r.PrintReports();// This also violates the Single Responsibility Principle (SRP) for the same reason as above.
//            r.BillReports();// This also violates the Single Responsibility Principle (SRP) for the same reason as above.
//        }
//    }
//}

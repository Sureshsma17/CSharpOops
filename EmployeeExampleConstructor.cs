//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class EmployeeExampleConstructor
//    {
//        class Employee
//        {
//            int Eid;
//            string Ename;
//            int Esal;
//            static string Companyname = "ABC";

//            public Employee()
//            {
//                Eid = 101;
//                Ename = "Suresh";
//                Esal = 30000;

//            }
//            public void HikeSalary()
//            {
//                int hikesal;
//                hikesal = Esal * 10 /100;
//                Esal = Esal + hikesal;
//                Console.WriteLine("Hike Salry is:" + Esal);
//            }
//            public void EmployeeDetails()
//            {
//                Console.WriteLine("Employee id is:" +Eid);
//                Console.WriteLine("Employee Name is:" +Ename);
//                Console.WriteLine("Employee Salary is:" + Esal);
//            }

//        }
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                Employee objemp = new Employee();
//                objemp.HikeSalary();
//                objemp.EmployeeDetails();

//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Employee
//    {
//        public int EmployeeId;
//        public string EmployeeName;
//        public double Basicsalary;

//        public Employee(int employeeId, string employeeName, double basicsalary)
//        {
//            EmployeeId = employeeId;
//            EmployeeName = employeeName;
//            Basicsalary = basicsalary;
//        }

//        public void CalculateNetSalary()
//        {
//            double HRA = Basicsalary * 0.2 ;
//            double DA = Basicsalary * 0.15;
//            double PF = Basicsalary * 0.10;
//            double NetSalary = Basicsalary + HRA + DA - PF;
//            Console.WriteLine("Net Salary of Employee " + EmployeeName + " is: " + NetSalary);
//        }
//    }
//    internal class Task2_Employee
//    {
//        static void Main(string[] args)
//        {
//            Employee emp = new Employee(1, "Suresh", 50000);
//            emp.CalculateNetSalary();
//        }
//    }
//}

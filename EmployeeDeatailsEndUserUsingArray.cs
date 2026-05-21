using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;

        public Employee(int Id, string Name, string Department, double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Department = Department;
            this.Salary = Salary;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Department: " + Department);
            Console.WriteLine("Employee Salary: " + Salary);
        }
    }
    internal class EmployeeDeatailsEndUserUsingArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Employees");
            int n = Convert.ToInt32(Console.ReadLine());

            Employee[] employees = new Employee[n];//array of employee class type

            for (int i = 0; i < n; i++)//loop to get employee details
            {
                Console.WriteLine("\n Enter Employee Details");

                Console.WriteLine("Enter Employee ID:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Employee Department:");
                string department = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary:");
                double salary = Convert.ToDouble(Console.ReadLine());

                employees[i] = new Employee(id, name, department, salary);//creating object of employee class and storing in array
            }
            Console.WriteLine("Employee Details are");
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].Display();
            }
        }
    }
}
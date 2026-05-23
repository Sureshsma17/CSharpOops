//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Employee
//    {
//        int id;
//        string name;
//        int sal;

//        public Employee()
//        {
//            id = 1;
//            name = "ABC";
//            sal = 25000;
//        }
//        public Employee(int id, string name, int sal)
//        {
//            this.id = id;
//            this.name = name;
//            this.sal = sal;
//        }
//        public Employee(int id)
//        {
//            this.id = id;
//        }
//        public Employee(string name)
//        {
//            this.name = name;
//        }
//        //public Employee(int sal)   //This shows error because it is dsame datatype as id datatype
//        //{
//        //    this.sal = sal;
//        //}
//        public void Display()
//        {
//            Console.WriteLine("Employee id: " + id);
//            Console.WriteLine("Employee name is: " + name);
//            Console.WriteLine("Employee Sal is: " + sal);
//        }
//    }
//    internal class SameDatatypeParameterizedconstructorEx
//    {
//        static void Main(string[] args)
//        {
//            Employee emp=new Employee();
//            emp.Display();

//            Employee e=new Employee(101);
//            e.Display();

//            Employee ee=new Employee("ABC");
//            ee.Display();

//            Employee emps=new Employee(1,"ABC",25000);
//            emps.Display();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class Student
    {
        static int sid = 1;

        private Student()
        {

        }
        public static void DisplayStudent()
        {
            Console.WriteLine("Student ID is: " + sid);
        }
    }
    internal class PrivateConstructorExample
    {
        static void Main(string[] args)
        {
            // Student s = new Student(); // This will cause a compile-time error because the constructor is private
            Student.DisplayStudent(); // This will work because DisplayStudentId is a static method
        }
    }
}

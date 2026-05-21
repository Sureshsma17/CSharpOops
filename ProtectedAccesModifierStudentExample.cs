//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Student
//    {
//        protected Student(int Sid)
//        {
//            Console.WriteLine("Protected Constructor called Id id:" + Sid);
//        }
//    }

//    class CollegeStudent:Student
//    {
//        public CollegeStudent(int Sid):base(Sid)
//        {
//            Console.WriteLine("College Student Called");
//        }
//    }
//    internal class ProtectedAccesModifierStudentExample
//    {
//        static void Main(string[] args)
//        {
//            CollegeStudent obj=new CollegeStudent(101);

//        }
//    }
//}

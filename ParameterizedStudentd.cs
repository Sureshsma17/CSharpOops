//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Student
//    {
//        int Sid;
//        string Sname;
//        double Sfee;

//        public Student()
//        {
//            Sid = 1;
//            Sname = "Suresh";
//            Sfee = 40000;
//        }
//        public Student(int sid,string sname,double sfee)
//        {
//            Sid = sid;
//            Sname = sname;
//            Sfee = sfee;
//        }
//        public void DisplayStudent()
//        {
//            Console.WriteLine("Student id is:" + Sid);
//            Console.WriteLine("Student Name is:"+Sname);
//            Console.WriteLine("Stuedent fee is:" + Sfee);
//        }
//    }
//    internal class ParameterizedStudentd
//    {
//        static void Main(string[] args)
//        {
//            {
//                Student s = new Student();
//                s.DisplayStudent();
//                Student stud = new Student(102,"Sai",50000);
//                stud.DisplayStudent();
//            }


//        }
//    }
//}

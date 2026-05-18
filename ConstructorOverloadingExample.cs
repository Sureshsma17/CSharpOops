//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Student
//    {
//        int sid;
//        string sname;
//        double age;

//        public Student()
//        {
//            sid = 1;
//            sname = "ABC";
//        }
//        public Student(int Sid)
//        {
//            sid = Sid;
//            sname = "Not Provided";
//        }
//        public Student(double Age)
//        {
//            age = Age;
//        }
//        public Student(int Sid,string Sname)
//        {
//            sid = Sid;
//            sname = Sname;
//        }
//        public Student(int Sid, string Sname, int Age) 
//        {
//            sid=Sid;
//            sname = Sname;
//            age = Age;


//        }
//        public void DisplayStudent()
//        {
//            Console.WriteLine("Student Id is:" + sid);
//            Console.WriteLine("Student Name is" + sname);
//            Console.WriteLine("Student Age id:" + age);
//        }
//    }
//    internal class ConstructorOverloadingExample
//    {
        
//        static void Main(string[] args)
//        {
//            Student stu = new Student();
//            stu.DisplayStudent();
//            Student stu1= new Student(101,"Suresh");
//            stu1.DisplayStudent();
//            Student stu2 = new Student(102);
//            stu2.DisplayStudent();
//            Student stu3 = new Student(103,25);
//            stu3.DisplayStudent();
//        }
//    }

    
//}

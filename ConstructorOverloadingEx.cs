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
//        string name;
//        string college;

//        public Student()
//        {
//            sid = 101;
//            name = "RAM";
//            college = "JNTU";
//        }

//        public Student(int sid, string name, string college)
//        {
//            this.sid = sid;
//            this.name = name;
//            this.college = college;
//        }
//        public Student(int sid, string name)
//        {
//            this.sid = sid;
//            this.name = name;
//            college = "Not Provided";
//        }

//        public void DisplayStudent()
//        {
//            Console.WriteLine("Student ID " + sid);
//            Console.WriteLine("Student Name is " + name);
//            Console.WriteLine("Student Collehe name is:" + college);
//        }
//    }

//    internal class ConstructorOverloadingEx
//    {
//        static void Main(string[] args)
//        {
//            Student stuobj = new Student();
//            stuobj.DisplayStudent();

//            Student stuparam = new Student(102, "Sai", "Anurag University");
//            stuparam.DisplayStudent();

//            Student param = new Student(103, "Akash", "CBIT");
//            param.DisplayStudent();

//            Student pstu = new Student(104, "Suresh");
//            pstu.DisplayStudent();
//        }
//    }


//}

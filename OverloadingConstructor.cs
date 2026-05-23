//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class OverloadingConstructor
//    {
//        class Student
//        {
//            int sid;
//            string name;
//            string college;

//            public Student()
//            {
//                sid = 101;
//                name = "RAM";
//                college = "JNTU";
//            }

//            public Student(int sid, string name, string college)
//            {
//                this.sid = sid;
//                this.name = name;
//                this.college = college;
//            }
//            public Student(int sid, string name)
//            {
//                this.sid = sid;
//                this.name = name;
//                college = "Not Provided";
//            }

//            public void DisplayStudent()
//            {
//                Console.WriteLine("Student ID " + sid);
//                Console.WriteLine("Student Name is " + name);
//                Console.WriteLine("Student Collehe name is:" + college);
//            }
//        }
//    }
//}

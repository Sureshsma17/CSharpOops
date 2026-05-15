//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class ParameterizedValuesStudent
//    {
//        class student
//        {
//            int sid;
//            string sname;
//            int sfee;

//            public student(int Sid,string Sname,int Sfee)
//            {
//                sid = Sid;
//                sname = Sname;
//                sfee = Sfee;
//            }
//            public void StudentDisplay()
//            {
//                Console.WriteLine("Student id is:" +sid);
//                Console.WriteLine("Student name is:" + sname);
//                Console.WriteLine("Student fee is:" + sfee);
//            }

//        }
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                student objstu = new student(101, "Suresh", 30000);
//                objstu.StudentDisplay();
//                student objstu1 = new student(102, "Sai", 35000);
//                objstu1.StudentDisplay();
//                student objstu2 = new student(103, "Yeshwanth", 40000);
//                objstu2.StudentDisplay();
//                student objstu3 = new student(104, "Vinay", 25000);
//                objstu3.StudentDisplay();
//                student objstu4 = new student(105, "Akash", 50000);
//                objstu4.StudentDisplay();
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Student
//    {
//        public void StudentDisplay(int sid, string sname)//call by value
//        {
//            Console.WriteLine("Student ID is:" + sid);
//            Console.WriteLine("Student Name is:" + sname);
//        }

//        public void UpdateAge(ref int age)//call by reference
//        {
//            age += 1;
//            Console.WriteLine("Updated age is: " + age);
//        }

//        public void Studentmarks(int sub1, int sub2, int sub3, out int total)//call by out
//        {
//            total = sub1 + sub2 + sub3;
//            Console.WriteLine("Total Marks is: " + total);
//        }


//    }
//    internal class CallByValue_Ref_Out_Student
//    {
//        static void Main(string[] args)
//        {
//            Student obj = new Student();
//            obj.StudentDisplay(1, "ABC");//call by value

//            int age = 20;
//            obj.UpdateAge(ref age);//call by reference

//            int x;
//            obj.Studentmarks(80, 90, 99, out x);//call by out


//        }
//    }
//}

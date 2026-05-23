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

//        public Student()//This is the constructor of the Student class, which is responsible for initializing
//                        //gthe student details (sid and sname).
//        {
//            sid = 1;
//            sname = "ABC";
//            Console.WriteLine("Student Details are assigned");//This constructor is responsible for initializing the student details,
//                                                              //adhering to the Single Responsibility Principle (SRP) of SOLID principles.

//        }
//        public void StudentDisplay()
//        {
//            Console.WriteLine("Student id is:" + sid);
//            Console.WriteLine("Student name is:" + sname);
            
//        }
//    }
//    internal class SOLIDPricipleConstructorExample
//    {
//        static void Main(string[] args)
//        {
//            Student student = new Student();
//            student.StudentDisplay();//In this example, the Student class has a constructor that initializes the
//                                     //student details (sid and sname) and a method StudentDisplay() that displays those details.
//                                     //The constructor is responsible for setting up the initial state of the object,
//                                     //while the StudentDisplay() method is responsible for displaying the information,
//                                     //adhering to the Single Responsibility Principle (SRP) of SOLID principles.
//        }
//    }
//}

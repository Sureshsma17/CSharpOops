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

//        public Student(int sid, string sname)
//        {
//            this.sid = sid;
//            this.sname = sname;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Student ID id is:"+ sid);
//            Console.WriteLine("Styudent Name is:"+ sname);
//            Console.WriteLine("--------------------------");
//        }
        

//    }
//    internal class ThisKeyEndUserArray
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Number of Students");
//            int n=Convert.ToInt32(Console.ReadLine());

//            Student[] students = new Student[n];//array of student class type

//            for (int i = 0; i < n; i++)//loop to get student details
//            {
//                Console.WriteLine("\n Enter Student Details");

//                Console.WriteLine("Enter Student ID:");
//                int id= Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Enter Student Name:");
//                string name= Console.ReadLine();

//                students[i]= new Student(id, name);//creating object of student class and storing in array
//            }
//            Console.WriteLine("Student Deatails are");
//            for(int i = 0;i < students.Length; i++)
//            {
//                students[i].Display();
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    abstract class Person
//    {
//        protected string name;
//        private int age;

//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//            Console.WriteLine("Person Constructor is called");
//        }

//        public void DisplayInfo()
//        {
//            Console.WriteLine($"Name is: {name} and Age is:{age}");
//        }
//        public abstract void Role();
       
//    }

//    class Student : Person
//    {
//        int rollno;

//        public Student(string name,int age,int rollno):base(name,age)
//        {

//            this.rollno = rollno;
//            Console.WriteLine("Student Constructor Called");

//        }
//        public void StudentRollno()[
//        {
//            Console.WriteLine("Roll number is: "+rollno);
//        }
//        public override void Role()
//        {
//            Console.WriteLine("I am aStudent");
//        }

//    }

//    class Teacher : Person
//    {
//        public string Subject;

//        public Teacher(string name, int age, string Subject) : base(name, age)
//        {
//            Console.WriteLine("Teacher Constuctor Called");
//        }
//        public void TeacherRole()
//        {
//            Console.WriteLine("I am Teacher:"+Subject);
//        }
//        public override void Role()
//        {
//            Console.WriteLine("Teaching C# Subject");
//        }
//    }
    
//    internal class Constructor_In_AbstractClass
//    {
//        static void Main(string[] args)
//        {
//            Person p = new Student("Sai",22,101);
//            //p.StudentRollno();
//            p.DisplayInfo();
//            p.Role();

//            p = new Teacher("xyz", 40, "C# Opps");
//            p.Role();
            


//        }

//    }
//}

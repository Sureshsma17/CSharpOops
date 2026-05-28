//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{ 
//       // Abstract Base Class
//        abstract class Person
//        {
//            // Fields
//            protected string name;
//            protected int age;

//            // Constructor
//            public Person(string name, int age)
//            {
//                this.name = name;
//                this.age = age;
//            }

//            // Method to display information
//            public void DisplayInformation()
//            {
//                Console.WriteLine("Name: " + name);
//                Console.WriteLine("Age: " + age);
//            }

//            // Abstract Method
//            public abstract void Role();
//        }

//        // Derived Class Student
//        class Student : Person
//        {
//            // Public Field
//            public int rollNo;

//            // Constructor
//            public Student(string name, int age, int rollNo)
//                : base(name, age)
//            {
//                this.rollNo = rollNo;
//            }

//            // Override Role Method
//            public override void Role()
//            {
//                Console.WriteLine("Role: Student");
//            }

//            // Study Method
//            public void Study()
//            {
//                Console.WriteLine("Student is studying.");
//            }
//        }

//        // Derived Class Teacher
//        class Teacher : Person
//        {
//            // Field
//            private string subject;

//            // Constructor
//            public Teacher(string name, int age, string subject)
//                : base(name, age)
//            {
//                this.subject = subject;
//            }

//            // Override Role Method
//            public override void Role()
//            {
//                Console.WriteLine("Role: Teacher");
//            }

//            // Teach Method
//            public void Teach()
//            {
//                Console.WriteLine("Teacher teaches " + subject);
//            }
//        }

//        // Main Class
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                // Student Object
//                Student s1 = new Student("Rahul", 18, 101);

//                Console.WriteLine("Student Details:");
//                s1.DisplayInformation();
//                Console.WriteLine("Roll No: " + s1.rollNo);
//                s1.Role();
//                s1.Study();

//                Console.WriteLine();

//                // Teacher Object
//                Teacher t1 = new Teacher("Anita", 35, "Mathematics");

//                Console.WriteLine("Teacher Details:");
//                t1.DisplayInformation();
//                t1.Role();
//                t1.Teach();
//            }
//        }

//    }

//}

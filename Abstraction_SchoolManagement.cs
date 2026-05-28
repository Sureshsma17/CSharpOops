using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    abstract class Person
    {
        protected string Name;
        protected int Age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void DisplayInformation()
        {
            Console.WriteLine("Person Name is: " + Name);
            Console.WriteLine("Person Age is: " + Age);

        }
        public abstract void Role();
    }

    class Student : Person
    {
        public int RollNo;

        public Student(string name, int age, int rollNo) : base(name, age)

        {
            this.RollNo = rollNo;
        }

        public override void Role()
        {
            
            Console.WriteLine("The Role of Student is:");
        }

        public void Study()
        {
            Console.WriteLine("Student is studying.");
        }

    }

    class Teacher : Person
    {
        public string Subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            this.Subject = subject;
        }
        public override void Role()
        {
           
            Console.WriteLine("The Role of Teacher is:");
        }
        public void Teach()
        {
            Console.WriteLine("Teacher teaches " + Subject);
        }
    }
    internal class Abstraction_SchoolManagement
    {
        static void Main(string[] args)
        {
            Person obj = new Student("Suresh", 29, 101);
            obj.DisplayInformation();
            //Console.WriteLine("Enter Roles");

            string Roleof = Console.ReadLine();
            obj.Role();

            obj = new Student();
            obj.Role();

            obj = new Teacher();
            obj.Role();


            //Student objstu = new Student("Suresh", 29, 101);

            //Console.WriteLine("Student Details:");
            //objstu.DisplayInformation();
            //Console.WriteLine("Roll No: " + objstu.RollNo);
            //objstu.Role();
            //objstu.Study();

            //Console.WriteLine();

            //// Teacher Object
            //Teacher objteach = new Teacher("SaiKuma8", 35, "C# Oops");

            //Console.WriteLine("Teacher Details:");
            //objteach.DisplayInformation();
            //objteach.Role();
            //objteach.Teach();




        }
    }
}

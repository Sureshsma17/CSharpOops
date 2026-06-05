//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    abstract class Person
//    {
//        public string name;
//        protected int age;

//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//            Console.WriteLine("Person is called");
//        }

//        public void DisplayInfo()
//        {
//            Console.WriteLine($"Person Name is:{name} and  Age is:{29}");
//        }

//        public virtual void VirtualDisp()
//        {
//            Console.WriteLine("Candiate Name is:"+ name);
//            Console.WriteLine("Candiate Age is: " + age);
//        }
//        public abstract void Role();
//    }

//    abstract class Student:Person
//    {
//        public int rollno;

//        public Student(string name,int age,int rollno):base(name,age)
//        {
//            this.rollno = rollno;
//            Console.WriteLine($"Name {name},Age{23} and roollno{201}");
//        }

//        public void Study()
//        {
//            Console.WriteLine($"Student is studying");
//        }

//        public virtual void VirtualStud()
//        {
//            Console.WriteLine($"Vitual method called");
//        }

//        public abstract void StudentRole();
//    }

//    class Teacher:Student
//    {
//        public string subject;

//        public Teacher(string name,int age,int rollno,string subject):base(name,age,rollno)
//        {
//            this.subject = subject;
//            Console.WriteLine("Teacher Construct called");
//        }
//        public virtual void Teach()
//        {
//            Console.WriteLine("virtual method of teacher");
//        }

//        public override void Role()
//        {
//            Console.WriteLine("Person");
//        }

//        public override void StudentRole()
//        {
//            Console.WriteLine("Student");
//        }

//        public override void VirtualDisp()
//        {
//            base.VirtualDisp();
//        }

//        public override void VirtualStud()
//        {
//            base.VirtualStud();
//        }

//    }
//    internal class AbstractionSchoolMngmnt
//    {
//        static void Main(string[] args)
//        {
//            Teacher T = new Teacher("sai",22,201,"C#");
//            T.StudentRole();
//            T.VirtualDisp();
//            T.Study();
//            T.Teach();
//            T.StudentRole();
//            T.VirtualStud();
            

//        }
//    }
//}

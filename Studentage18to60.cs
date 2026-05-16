using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpOops
{
    class Student18to60
    {
        int Sid;
        string Sname;
        byte Age;

        public Student18to60()
        {
            Sid = 1;
            Sname = "Ram";
            Age = 28;
        }
        public Student18to60(int sid, string sname, byte age)
        {
            Sid = sid;
            Sname = sname;
            Age = age;
        }
        public void DisplayStudent()
        {
            Console.WriteLine("Student id is:" + Sid);
            Console.WriteLine("Student Name is:" + Sname);
            Console.WriteLine("Stuedent Age is:" + Age);
        }
        public void Age18to60()
        {
            if (Age >= 18 && Age <= 60)
            {
                Console.WriteLine("Age is valid (between 18 and 60).");
                // Your logic here
            }
            else
            {
                Console.WriteLine("Age must be between 18 and 60.");
            }
        }
    }

    internal class ParameterizedStudentd
    {

        static void Main(string[] args)
        {
            {
                Student18to60 s = new Student18to60();
                s.DisplayStudent();
                Student18to60 stud = new Student18to60(102, "Sai", 22);
                stud.DisplayStudent();
                Student18to60 studage = new Student18to60(103,"Raju",61);
                studage.DisplayStudent();
                studage.Age18to60();


            }


        }
    }
}

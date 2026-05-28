//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    abstract class AbstractClass
//    {
//        public void Start()
//        {
//            Console.WriteLine("Started the Class");
//        }
//        public void Resume()
//        {
//            Console.WriteLine("Resuned the Class");
//        }
//        public void Display()
//        {
//            Console.WriteLine("Welcome");
//        }
//        public abstract void End();
//    }
//    class DerivedClass : AbstractClass
//    {
//        public override void End()
//        {
//            Console.WriteLine("Session has End");
//        }
//    }
//    internal class Abstraction_Examplecs
//    {
//        static void Main(string[] args)
//        {
//            AbstractClass obj = new DerivedClass();
//            obj.Display();
//            obj.Start();
//            obj.Resume();
//            obj.End();

//        }
//    }
//}

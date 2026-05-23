//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class AccessModifier
//    {
//        public int a = 10;

//        public void MyMethod()
//        {
//            AccessModifier obj = new AccessModifier();
//            Console.WriteLine("Value of a under MyMethod method is " + obj.a);
//        }
        
//    }
//    class PublicClass
//    {
//        public void PublicMethod()
//        {
//            AccessModifier obj = new AccessModifier();
//            Console.WriteLine("Value of a under Public method is " + obj.a);
//        }

//    }
//    internal class PublicAccessModExample
//    {
//        static void Main(string[] args)
//        {
//            AccessModifier obj= new AccessModifier();
//            obj.MyMethod();
//            Console.WriteLine("Value of a under Main method is " + obj.a);
//            PublicClass pc=new PublicClass();
//            pc.PublicMethod();
//        }
//    }
//}

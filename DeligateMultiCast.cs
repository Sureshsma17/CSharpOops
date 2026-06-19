//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class MyClass
//    {
//        public void Method1()
//        {
//            Console.WriteLine("Method1");
//        }
//        public void Method2()
//        {
//            Console.WriteLine("Method2");
//        }
//    }
//    internal delegate void MyDelegate();

//    internal class DeligateMultiCast
//    {
//        static void Main(string[] args)
//        {
//            MyClass obj = new MyClass();
//            MyDelegate del = obj.Method1;
//            del += obj.Method2;
//            del();
//        }

//    }
//}

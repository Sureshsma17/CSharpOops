//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class myclass1
//    {
//        protected int a = 10;

//        public void Method()
//        {
//            Console.WriteLine("value of a is:" + a);
//        }
//    }
//    class newclass1 : myclass1
//    {
//        public newclass1()
//        {
//            a = 10;
//        }
//        public void Method2()
//        {
//            Console.WriteLine("a value is:" + a);
//        }


//    }
//    internal class ProtectedAccessModifierEx2
//    {
//        static void Main(string[] args)
//        {
//            newclass1 obj = new newclass1();
//            obj.Method();
//            obj.Method2();
//        }
//    }
//}

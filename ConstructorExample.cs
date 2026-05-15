//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class ConstructorExample
//    {
//        class myclass
//        {
//            int a;
//            int b;

//            //public myclass()
//            //{
//            //    a = 10;
//            //    b = 20;
//            //    Console.WriteLine("Constructor Called");
//            //}
//            public void Greet()
//            {
//                a = 10;
//                b = 20;
//                Console.WriteLine("Value of a:" + a);
//                Console.WriteLine("Value of b:" + b);
//                Console.WriteLine("Hello World");
//            }
//            public int Greet2()
//            {
//                return a + b;
//            }
//            public int sub()
//            {
//                return a - b;
//            }
//            public int mul()
//            {
//                return a * b;
//            }
//            public int div()
//            {
//                return a / b;
//            }

//        }
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                myclass obj=new myclass();
//                obj.Greet();
//                int result =obj.Greet2();
//                Console.WriteLine("Resuly of Greet2:" + result);
//                int subres = obj.sub();
//                Console.WriteLine("Sub is {0}",subres);
//                int mulres = obj.mul();
//                Console.WriteLine("Mul is {0}",mulres);
//                int divres = obj.div();
//                Console.WriteLine("Div is {0}",divres);
//            }
//        }
//    }
    
//}

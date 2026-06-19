//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class MyClass
//    {
//        internal void Method1()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Method1 is:" + i);
//            }
//        }

//        internal void Method2()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Method2 is:" + i);
//            }
//        }

//        internal class MultiThreadindEXcs
//        {
//            static void Main(string[] args)
//            {
//                MyClass obj = new MyClass();

//                ThreadStart tstart1 = new ThreadStart(obj.Method1);
//                Thread thr1 = new Thread(tstart1);
//                thr1.Start();

//                ThreadStart tstart2 = new ThreadStart(obj.Method2);
//                Thread thr2 = new Thread(tstart2);
//                thr2.Start();
//            }
//        }
//    }
//}

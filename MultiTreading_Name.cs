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
//        internal void Method()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
//            }
//        }
//    }

//    internal class MultiTreading_Name
//    {
//        static void Main(string[] args)
//        {
//            MyClass obj = new MyClass();
//            ThreadStart tstart = new ThreadStart(obj.Method);
//            Thread tstr1 = new Thread(tstart);
//            tstr1.Name = "Method1";
//            tstr1.Start();

//            Thread tstr2 = new Thread(tstart);
//            tstr2.Name = "Method 2";
//            tstr2.Start();
//        }

//    }
//}

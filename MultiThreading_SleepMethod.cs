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
//                Console.WriteLine(Thread.CurrentThread.Name + " is going to sleep :" + i);
//                Thread.Sleep(new TimeSpan(0, 0, 10));
//                Thread.Sleep(1000);
//            }
//        }
//    }

//    internal class MultiThreading_SleepMethod
//    {
//        static void Main(string[] args)
//        {
//            MyClass obj = new MyClass();
//            ThreadStart tstart = new ThreadStart(obj.Method);
//            Thread thr = new Thread(tstart);
//            thr.Name = "Sleep Thread";
//            thr.Start();
//        }
//    }


//}

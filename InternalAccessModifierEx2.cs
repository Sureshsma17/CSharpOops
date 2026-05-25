//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class myclass
//    {
//        internal int a = 10;

//        public void mymethod()
//        {
//            Console.WriteLine("The value of a is under mymethod is"+a);
//        }
//    }
//    class newclass
//    {
//        public void newmethod()
//        {
//            myclass obj=new myclass();
//            Console.WriteLine("The value of a is under newmethod is:" + obj.a);
//        }
//    }
//    internal class InternalAccessModifierEx2
//    {
//        static void Main(string[] args)
//        {
//            myclass mc = new myclass();
//            mc.mymethod();
//            Console.WriteLine("value of a under main method is:" + mc.a);
//            newclass nc = new newclass();
//            nc.newmethod();
//        }
//    }
//}

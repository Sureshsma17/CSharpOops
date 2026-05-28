//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class myclass
//    {
//        public void Display()
//        {
//            Console.WriteLine("Welcome to Oops");

//        }
//        public virtual void Show()
//        {
//            Console.WriteLine("Show is Calling");
//        }
//    }
//    class dc : myclass
//    {
//        public void Message()
//        {
//            Console.WriteLine("Message is Calling");
//        }
//        public override void Show()
//        {
//            Console.WriteLine("This is Overridden Method");
//        }
//    }
//    internal class VitualMethod_Example
//    {
//        static void Main(string[] args)
//        {
//            myclass obj = new myclass();
//            obj.Display();
//            obj.Show();

//            dc objdc = new dc();
//            objdc.Message();
//            objdc.Show();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    public class AcceesData
//    {
//        private int a;//private access modifier is used to restrict the access of data members within the class only
//        private int b;//private access modifier is used to restrict the access of data members within the class only

//        public void Display()
//        {
//            a = 10;
//            b = 20;
//            Console.WriteLine("value of a is:" + a);
//            Console.WriteLine("value of b is:" + b);
//        }
//    }

//    public class NewClass
//    {
//        public void MyMethod()
//        {
//            AcceesData obj=new AcceesData();
//            Console.WriteLine("value of a is:" + obj.a);//error because a is private
//            Console.WriteLine("value of b is:" + obj.b);//error because b is private
//        }
//    }
//    internal class PrivateAccessModifierExample_Error_
//    {
//        static void Main(string[] args)
//        {
//            AcceesData obj = new AcceesData();
//            obj.Display();
//            Console.WriteLine(obj.a);//error because a is private
//            Console.WriteLine(obj.b);//error because b is private

//            NewClass nc=new NewClass();
//            nc.MyMethod();
//        }
//    }
//}

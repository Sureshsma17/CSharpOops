//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class BaseClass
//            {
//        public virtual void Display()
//        {
//            Console.WriteLine("Base class display method");
//        }
//    }
//    class DerivedClass : BaseClass
//    {
//        public override void Display()
//        {
//            Console.WriteLine("Derived class display method");
//        }
//    }
//    internal class Overriding_Poly
//    {
//        static void Main(string[] args)
//        {
//            BaseClass baseObj = new BaseClass();
//            baseObj.Display(); // Output: Base class display method
//            //DerivedClass derivedObj = new DerivedClass();
//            //derivedObj.Display(); // Output: Derived class display method
//            BaseClass polyObj = new DerivedClass();
//            polyObj.Display(); // Output: Derived class display method (polymorphism)
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class StaticVariable
//    {
//        public int InstanceCount = 0;
//        public static int StaticCount = 0;

//        public void Increment()
//        {

//            InstanceCount++;
//            StaticCount++;
//            Console.WriteLine("Instance Count: " + InstanceCount);
//            Console.WriteLine("Static Count: " + StaticCount);
//        }
//    }
//    internal class StaticVariableDemonstration
//    {
//        static void Main(string[] args)
//        {
//            StaticVariable c1 = new StaticVariable();
//            StaticVariable c2 = new StaticVariable();

//            Console.WriteLine("c1 :");
//            c1.Increment(); // Instance Count: 1, Static Count: 1
//            c1.Increment(); // Instance Count: 2, Static Count: 2

//            Console.WriteLine("\n c2:");
//            c2.Increment(); // Instance Count: 1, Static Count: 3
//            c2.Increment(); // Instance Count: 2, Static Count: 4


//        }
//    }
//}

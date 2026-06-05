//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Counter
//    {
//        public int InstanceCount = 0;//Instance variable(each object will have its own copy of variable)
//        public static int StaticCount = 0;//Static variable(shared among all objects of the class)

//        public void Increment()
//        {

//            InstanceCount++;//Local instance variable increases by 1 each time the method is called
//            StaticCount++;//Static variable increases globally
//            Console.WriteLine("Instance Count: " + InstanceCount);
//            Console.WriteLine("Static Count: " + StaticCount);
//        }
//    }
//    internal class InstanceCountStaticCountExample
//    {
//        static void Main(string[] args)
//        {
//            Counter counter1 = new Counter();
//            Counter counter2 = new Counter();

//            Console.WriteLine("Counter 1:");
//            counter1.Increment(); // Instance Count: 1, Static Count: 1
//            counter1.Increment(); // Instance Count: 2, Static Count: 2

//            Console.WriteLine("\nCounter 2:");
//            counter2.Increment(); // Instance Count: 1, Static Count: 3
//            counter2.Increment(); // Instance Count: 2, Static Count: 4


//        }
//    }
//}

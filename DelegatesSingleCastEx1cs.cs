//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Calculate
//    {
//        internal int Add(int a, int b) //method signature
//        {
//            return a + b;
//        }
//    }
//    internal delegate int MyDelegate(int x, int y); //delegate signature

//    internal class DelegatesEx1cs
//    {
//        static void Main(string[] args)
//        {
//            Calculate obj = new Calculate();  //creating object of Calculate class
//            MyDelegate objdel = new MyDelegate(obj.Add); //creating delegate object and associating it with method
//            int result = objdel(100, 200);  //invoking the method using delegate object
//            Console.WriteLine(result);  //output: 300
//        }

//    }
//}

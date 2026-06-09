using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    static class MyClass
    {
        static int a;

        static MyClass()  //static constructor
        {
            a = 10;
        }

        internal static void Display() //static method
        {
            Console.WriteLine("Value of a is: " + a);
        }

        internal class StaticClass
        {
            static void Main(string[] args)
            {
                MyClass.Display();
            }

        }
    }
}

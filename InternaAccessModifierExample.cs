using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class MyClass
    {
        internal int a;

        public MyClass()
        {
            a = 10;
        }
        public void Display()
        {
            Console.WriteLine("value of a is:" + a);

        }
        
    }
    class NewClass
    {
        public void Method()
        {
            MyClass obj = new MyClass();
            Console.WriteLine(obj.a);
        }

    }
    internal class InternaAccessModifierExample
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display();
            NewClass obj1 = new NewClass();
            obj1.Method();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    internal class MethodswithParametersNoReturnValue
    {
        class  Myclass
        {
            public void Add(int a,int b)
            {
                int c = a + b;
                Console.WriteLine("The sum of a and b is: " + c);
            }
            public void Greet(int x)
            {
                Console.WriteLine("Hello,Welcome to methods",+x);
            }
        }

        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.Add(10, 20);
            myclass.Greet(10);
        }
    }
}

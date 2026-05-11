using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    internal class PrintNameWithotReturnWithoutParameter
    {
        class Myclass
        {
            public void PrintName()
            {
                Console.WriteLine("Hello, My Name is Suresh");
            }
        }
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.PrintName(); 
        }
    }
}

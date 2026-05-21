using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class newclass
    {
        int a;
        int b;

        public newclass(int a,int b)
        {
            this.a = a;
            this.b = b;

        }
        public void Add()
        {
            int c = a + b;
            Console.WriteLine("Sum of a and b is:"+c);
        }
    }
    internal class ThisKeywordExample
    {
        static void Main(string[] args)
        {
            newclass obj = new newclass(10, 20);
            obj.Add();
        }
    }
}

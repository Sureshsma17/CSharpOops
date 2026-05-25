using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class myclass
    {
        protected int a=10;

        public void mymethod()
        {
            Console.WriteLine("value of a under mymethod is:"+a);
        }
    }
    class newclass:myclass
    {
        public void newmethod()
        {
            Console.WriteLine("value of a under new method is:" + a);
        }
    }
    internal class ProtectedAccessmodifierEx3
    {
        static void Main(string[] args)
        {
            newclass obj = new newclass();
            obj.newmethod();
            obj.mymethod();
        }
    }
}

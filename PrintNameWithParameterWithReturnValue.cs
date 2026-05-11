using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    internal class PrintNameWithParameterWithReturnValue
    {
        class Myclass
        { 
            public string PrintName(string Firstname,string Lastname)
            {
                string Fullname;
               Fullname = Firstname + Lastname;
                return Fullname;
            }
            static void Main(string[] args)
            {
                Myclass myclass = new Myclass();
                string FN = myclass.PrintName("Suresh ","M");
                Console.WriteLine("The Return Value is: "+ FN);
            }
        }
    }
}

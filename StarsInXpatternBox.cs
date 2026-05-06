//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class StarsInXpatternBox
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number of rows for the X pattern Box:");
//            int rows = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= rows; i++)
//            {
//                for (int j = 1; j <= rows; j++)
//                {
//                    if (i == 1 || j == 1 || i == rows || j == rows || i == j || j == (rows - i + 1))
//                    {
//                        Console.Write("*");
//                    }
//                    else
//                    {
//                        Console.Write(" ");
//                    }
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class StarLeftTriangle
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number of rows for the Left Triangle:");
//            int rows = int.Parse(Console.ReadLine());

//            //for (int i = 1; i <= rows; i++)
//            //{
//            //    for (int j = i; j <= rows; j++)
//            //    {
//            //        Console.Write(" ");
//            //    }
//            //    for (int k = 1; k <= i; k++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}
//            for (int i = 1; i <= rows; i++)
//            {
//                for (int j = i; j <= rows; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = 1; k <= i; k++)
//                {
//                    if(k == 1 || i == rows || k == i) //printing stars at the first and last position of each row and for the last row, print all stars
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

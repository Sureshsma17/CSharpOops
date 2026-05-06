//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class StarPyramidandRevervese
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number of rows for the Pyramid:");
//            int rows = int.Parse(Console.ReadLine());


//            for (int i = 1; i <= rows; i++)
//            {
//                for (int j = i; j < rows; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = 1; k <= (2 * i - 1); k++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//            for (int i = rows - 1; i >= 1; i--)
//            {
//                for (int j = i; j < rows; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = 1; k <= (2 * i - 1); k++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{

//    internal class Task1_PalindromeandArmstrong
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;
//            int rem;
//            Console.WriteLine("Enter a number:");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int temp = num;

//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = (sum * 10) + rem;
//                num = num / 10;
//            }

//            if (temp == sum)
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("Not Palindrome");
//            }
//        }
//    }

//}


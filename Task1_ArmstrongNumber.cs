//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class Task1_ArmstrongNumber
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a Number");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int sum = 0;
//            int rem, temp;
//            temp = num;

//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = sum + (rem * rem * rem);
//                num = num / 10;
//            }
//            if (sum == temp)
//            {
//                Console.WriteLine(temp + " is a Armstrong Number");
//            }
//            else
//            {
//                Console.WriteLine(temp + " is Not a Armstrong Number");
//            }
//        }
//    }
//}

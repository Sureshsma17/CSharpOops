//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class ArmstrongNumber
//    {
//         static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a Number:");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int rem, temp, sum = 0;
//            temp = num;
//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = sum + (rem * rem * rem);
//                num = num / 10;


//            }
//            if (sum == temp)
//            {
//                Console.WriteLine(temp + " is a Armstrong number:");

//            }
//            else
//            {
//                Console.WriteLine(temp + " is not an Armstrong number:");
//            }
//        }
//    }
//}

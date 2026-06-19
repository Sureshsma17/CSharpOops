//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class GenericList_Ex
//    {
//        static void Main(string[] args)
//        {
//            List<int> numbers = new List<int>();    // Create a generic list of integers
//            numbers.Add(10);
//            numbers.Add(50);
//            numbers.Add(20);
//            numbers.Add(30);
//            numbers.Add(40);
//            Console.WriteLine("Numbers in the list:");

//            foreach (int i in numbers)
//            {
//                Console.WriteLine(i);
//            }

//            numbers.Sort();  // Sort the list in ascending order
//            Console.WriteLine("Numbers in the list after sorting:");
//            foreach (int i in numbers)
//            {
//                Console.WriteLine(i);
//            }

//            numbers.Remove(30);  // Remove the number 30 from the list
//            Console.WriteLine("Numbers in the list after removing 30:");
//            foreach (int i in numbers)
//            {
//                Console.WriteLine(i);
//            }

//            Console.WriteLine("Total number of elements in the list: " + numbers.Count);  // Get the count of elements in the list
//            Console.WriteLine("Contains 20: " + numbers.Contains(20));  // Check if the list contains the number 20
            
//            numbers.Reverse();  // Reverse the order of the list
//            Console.WriteLine("Numbers in the list after reversing:");
//            foreach (int i in numbers)
//            {
//                Console.WriteLine(i);
//            }

//            numbers.Clear();  // Clear all elements from the list
//            Console.WriteLine("Total Number of elements in the list after clearing: " + numbers.Count);  // Get the count of elements in the list after clearing
//        }
//    }
//}

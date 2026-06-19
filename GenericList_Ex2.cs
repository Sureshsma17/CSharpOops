//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class GenericList_Ex2
//    {
//        static void Main(string[] args)
//        {
//            List<string> names = new List<string>();    // Create a generic list of strings
//            names.Add("Vinay");
//            names.Add("Akash");
//            names.Add("Sai");
//            names.Add("Nitish");
//            Console.WriteLine("Names in the list:");
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            names.Sort();  // Sort the list in ascending order
//            Console.WriteLine("Names in the list after sorting:");
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            names.Remove("Sai");  // Remove the name "Sai" from the list
//            Console.WriteLine("Names in the list after removing Sai:");
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            Console.WriteLine( "Total number of elements in the list: " + names.Count);  // Get the count of elements in the list
//            Console.WriteLine("Contains Akash: " + names.Contains("Akash"));  // Check if the list contains the name "Akash"
//            names.Reverse();  // Reverse the order of the list
//            Console.WriteLine("Names in the list after reversing:");
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            names.Clear();  // Clear all elements from the list
//            Console.WriteLine("Total Number of elements in the list after clearing: " + names.Count);  // Get the count of elements in the list after clearing

//        }
//    }
//}

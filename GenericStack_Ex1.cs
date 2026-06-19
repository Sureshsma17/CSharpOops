using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    internal class GenericStack_Ex1
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();    // Create a generic stack of strings
            stack.Push("Ganesh");
            stack.Push("Rajesh");
            stack.Push("Ramesh");
            stack.Push("Mahesh");
            Console.WriteLine("Stack elements are:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Popped element: " + stack.Pop());  // Pop the top element from the stack
            Console.WriteLine("Stack elements after popping:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

             Console.WriteLine("Peeked element: " + stack.Peek());  // Peek at the top element of the stack without removing it
             Console.WriteLine("Stack elements after peeking:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total number of elements in the stack: " + stack.Count);  // Get the count of elements in the stack
            Console.WriteLine("Contains Rajesh: " + stack.Contains("Rajesh"));  // Check if the stack contains the name "Rajesh"
            stack.Clear();  // Clear all elements from the stack
            Console.WriteLine("Total Number of elements in the stack after clearing: " + stack.Count);  // Get the count of elements in the stack after clearing

        }
    }
}

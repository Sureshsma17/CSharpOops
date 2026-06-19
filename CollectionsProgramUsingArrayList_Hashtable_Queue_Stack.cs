//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    internal class CollectionsProgramUsingArrayList_Hashtable_Queue_Stack
//    {
//        static void Main(string[] args)
//        {
//            //1.ArrayList: Create an ArrayList to store student names. Add at least five names to the ArrayList and display
//            //the contents.
//            ArrayList s = new ArrayList();
//            s.Add("RAMA");
//            s.Add("Nitish");
//            s.Add("Suresh");
//            s.Add("Ravi");
//            s.Add("Praveen");
//            Console.WriteLine("No.of students");
//            foreach (string var in s)
//            {
//                Console.WriteLine(var);
//            }

//            //2.Hashtable: Create a hashtable to store student roll numbers as keys and their names as values.
//            //Display the contents of the hashtable.
//            Hashtable ht = new Hashtable();
//            for (int i = 0; i < s.Count; i++)
//            {
//                ht.Add(i, s[i]);
//            }
//            Console.WriteLine("No.of students with rollno");
//            foreach (DictionaryEntry entry in ht)
//            {
//                Console.WriteLine("key {0} value {1}", entry.Key, entry.Value);
//            }

//            //3.Queue: Create a queue to simulate a line of people waiting for lunch. Enqueue at least three names and
//            //then dequeue one name. Display the contents of the queue before and after the dequeue operation.
//            Queue qt = new Queue();
//            qt.Enqueue("naveen");
//            qt.Enqueue("sajay");
//            qt.Enqueue("raghu");
//            Console.WriteLine(" Remove an Element from Queue " + qt.Dequeue());
//            foreach (string var in qt)
//            {
//                Console.WriteLine(var);
//            }

//            //4.Stack: Create a stack to represent books in a library. Push at least three book titles onto the stack and
//            //then pop one title. Display the contents of the stack before and after the pop operation.
//            Console.WriteLine("Books in library");
//            Stack st = new Stack();
//            st.Push("chemistry");
//            st.Push("geography");
//            st.Push("thermodynamics");
//            Console.WriteLine(" Removed an book from library " + st.Pop());
//            foreach (string var in st)
//            {
//                Console.WriteLine(var);
//            }

//        }
//    }
//}
//        //static void Main(string[] args)
//        //{
//        //    // 1) List
//        //    List<string> students = new List<string> { "Sai", "Akash", "Vinay" };
//        //    Console.WriteLine("List of Students:");
//        //    foreach (var student in students)
//        //        Console.WriteLine(student);

//        //    // 2) Hashtable
//        //    Hashtable studentTable = new Hashtable();
//        //    studentTable.Add(1, "Sai");
//        //    studentTable.Add(2, "Akash");
//        //    studentTable.Add(3, "Vinay");

//        //    Console.WriteLine("Hashtable (Roll No -> Name):");
//        //    foreach (DictionaryEntry entry in studentTable)
//        //    { 
//        //        Console.WriteLine("key {0} value {1}", entry.Key, entry.Value);
//        //    }

//        //    // 3) Queue
//        //    Queue<string> lunchQueue = new Queue<string>();
//        //    lunchQueue.Enqueue("Sai");
//        //    lunchQueue.Enqueue("Akash");
//        //    lunchQueue.Enqueue("Vinay");

//        //    Console.WriteLine("Queue before dequeue:");
//        //    foreach (var name in lunchQueue)
//        //    { 
//        //        Console.WriteLine(name);
//        //    }

//        //    lunchQueue.Dequeue();

//        //    Console.WriteLine("Queue after dequeue:");
//        //    foreach (var name in lunchQueue)
//        //    { 
//        //        Console.WriteLine(name);
//        //    }

//        //    // 4) Stack
//        //    Stack<string> books = new Stack<string>();
//        //    books.Push("Book A");
//        //    books.Push("Book B");
//        //    books.Push("Book C");

//        //    Console.WriteLine("Stack before pop:");
//        //    foreach (var book in books)
//        //    { 
//        //        Console.WriteLine(book);
//        //    }

//        //    books.Pop();

//        //    Console.WriteLine("Stack after pop:");
//        //    foreach (var book in books)
//        //    {
//        //        Console.WriteLine(book);
//        //    }

//            //Step 3: Explanation
//            //List:is used for storing and iterating over student names.
//            //Hashtable:stores roll numbers as keys and names as values.
//            //Queue:follows FIFO(First In, First Out) for simulating a lunch line.
//            //Stack:follows LIFO(Last In, First Out) for simulating books in a library.
//            //Final Answer
//            //The above C# program demonstrates the use of List, Hashtable, Queue, and Stack collections as required.
//    //    }
//    //}
////}

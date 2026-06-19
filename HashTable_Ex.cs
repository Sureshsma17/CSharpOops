//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace CSharpOops
//{
//    internal class HashTable_Ex
//    {
//        static void Main(string[] args)
//        {
//            Hashtable ht = new Hashtable();

//            ht.Add("1", "One");
//            ht.Add("2", "Two");
//            ht.Add("3", "Three");

//            Console.WriteLine("hash table elements");

//            foreach (DictionaryEntry entry in ht)
//            {
//                Console.WriteLine("key {0} value {1}", entry.Key, entry.Value);
//            }

//            Console.WriteLine("Access by key");
//            Console.WriteLine("Key :1 value {0}", ht["1"]);

//            Console.WriteLine("Remove by key");
//            ht.Remove("2");

//            foreach (DictionaryEntry entry in ht)
//            {
//                Console.WriteLine("key {0} value {1}", entry.Key, entry.Value);
//            }

//            Console.WriteLine("Contains key: 1 {0}", ht.ContainsKey("1"));
//        }
//    }
//}




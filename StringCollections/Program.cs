using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            HashSet<string> hashSet = new HashSet<string>();

            // Add elements to the collections
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            list.Add("five");
            list.Add("five"); // Duplicate element

            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");
            stack.Push("five");
            stack.Push("five"); // Duplicate element

            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("four");
            queue.Enqueue("five");
            queue.Enqueue("five"); // Duplicate element

            hashSet.Add("one");
            hashSet.Add("two");
            hashSet.Add("three");
            hashSet.Add("four");
            hashSet.Add("five");
            hashSet.Add("five"); // Duplicate element
        }
    }
}

using System;
using System.Collections;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class StackCollection
    {
        public static void Run()
        {
            // Creating stack
            Stack lifo = new Stack();
            Stack lifoWithCapacity = new Stack(15); // Creating stack with capacity

            // Copying array into stack
            ArrayList array = new ArrayList();
            array.Add("String 1");
            array.Add("String 2");
            Stack lifoWithCopyOfArray = new Stack(array);

            // Using stack functions
            Stack breadcrumbs = new Stack();

            // Pushing elements to the stack
            breadcrumbs.Push("Home Page");
            breadcrumbs.Push("Articles");
            breadcrumbs.Push("C#");
            Console.WriteLine("Count {0}", breadcrumbs.Count);

            // Peek method
            string nextPeek = breadcrumbs.Peek().ToString();
            Console.WriteLine(nextPeek);

            // Popping elements from the stack
            while (breadcrumbs.Count != 0)
            {
                string next = breadcrumbs.Pop().ToString();
                Console.WriteLine(next);
            }

            // Contains
            Console.WriteLine(breadcrumbs.Contains("Articles"));

            // Clear
            breadcrumbs.Clear();

            // ToArray
            object[] breadcrumbsArray = breadcrumbs.ToArray();

            // Creating Thread-Safe Stack Wrapper
            Stack threadSafeStack = Stack.Synchronized(lifo);
            Console.WriteLine(threadSafeStack.IsSynchronized);
        }
    }
}

using System;
using System.Collections;
using static System.Console;

namespace Day05.Lib
{
    public class CollectionGeneric
    {
        public void ArrayListExample(int count)
        {
            var arrayList = new ArrayList();
            var numRandom = new Random(count);
            WriteLine($"Creating an ArrayList with capacity: {count}");
            for (var countIndex = 0; countIndex < count; countIndex++)
                arrayList.Add(numRandom.Next(count));
            WriteLine($"Capacity: {arrayList.Capacity}");
            WriteLine($"Count: {arrayList.Count}");

            Write("ArrayList original contents: ");
            PrintArrayListContents(arrayList);
            WriteLine();
            arrayList.Reverse();
            Write("ArrayList reversed contents: ");
            PrintArrayListContents(arrayList);
            WriteLine();
            Write("ArrayList sorted Content: ");
            arrayList.Sort();
            PrintArrayListContents(arrayList);
            WriteLine();
            ReadKey();
        }

        public void HashTableExample()
        {
            WriteLine("Creating HashTable");
            var hashtable = new Hashtable
            {
                {1, "Gaurav Aroraa"},
                {2, "Vikas Tiwari"},
                {3, "Denim Pinto"},
                {4, "Diwakar"},
                {5, "Merint"}
            };
            hashtable.Add(11, "Rama");
            WriteLine("Reading HashTable Keys");
            WriteLine($"Count: {hashtable.Count}");
            var fixedSize = hashtable.IsFixedSize ? " fixed size." : " not fixed size.";
            WriteLine($"HashTable is {fixedSize} .");
            WriteLine($"HashTable is ReadOnly : {hashtable.IsReadOnly} ");
            foreach (var hashtableKey in hashtable.Keys)
                WriteLine($"Key :{hashtableKey} - value : {hashtable[hashtableKey]}");
        }

        public void SortedListExample()
        {
            WriteLine("Creating SortedList");
            var sortedList = new SortedList
            {
                {1, "Gaurav Aroraa"},
                {2, "Vikas Tiwari"},
                {3, "Denim Pinto"},
                {4, "Diwakar"},
                {5, "Merint"},
                {11, "Rama"}
            };
            WriteLine("Reading SortedList Keys");
            WriteLine($"Capacity: {sortedList.Capacity}");
            WriteLine($"Count: {sortedList.Count}");
            var fixedSize = sortedList.IsFixedSize ? " fixed size." : " not fixed size.";
            WriteLine($"SortedList is {fixedSize} .");
            WriteLine($"SortedList is ReadOnly : {sortedList.IsReadOnly} ");
            foreach (var key in sortedList.Keys)
                WriteLine($"Key :{key} - value : {sortedList[key]}");
        }

        public void StackExample()
        {
            WriteLine("Creating Stack");
            var stackList = new Stack();
            stackList.Push("Gaurav Aroraa");
            stackList.Push("Vikas Tiwari");
            stackList.Push("Denim Pinto");
            stackList.Push("Diwakar");
            stackList.Push("Merint");

            WriteLine("Reading stack items");
            ReadingStack(stackList);
            WriteLine();
            WriteLine($"Count: {stackList.Count}");

            WriteLine("Adding more items.");
            stackList.Push("Rama");
            stackList.Push("Shama");
            WriteLine();
            WriteLine($"Count: {stackList.Count}");
            WriteLine($"Next value without removing:{stackList.Peek()}");
            WriteLine();
            WriteLine("Reading stack items.");
            ReadingStack(stackList);
            WriteLine();
            WriteLine($"Remove item: {stackList.Pop()}");
            WriteLine();
            WriteLine("Reading stack items after removing an item.");
            ReadingStack(stackList);
            ReadLine();
        }

        public void QueueExample()
        {
            WriteLine("Creating Queue");
            Queue queue = new Queue();
            queue.Enqueue("Gaurav Aroraa");
            queue.Enqueue("Vikas Tiwari");
            queue.Enqueue("Denim Pinto");
            queue.Enqueue("Diwakar");
            queue.Enqueue("Merint");

            WriteLine("Reading Queue items");
            ReadingQueue(queue);
            WriteLine();
            WriteLine($"Count: {queue.Count}");

            WriteLine("Adding more items.");
            queue.Enqueue("Rama");
            queue.Enqueue("Shama");
            WriteLine();
            WriteLine($"Count: {queue.Count}");
            WriteLine($"Next value without removing:{queue.Peek()}");
            WriteLine();
            WriteLine("Reading queue items.");
            ReadingQueue(queue);
            WriteLine();
            WriteLine($"Remove item: {queue.Dequeue()}");
            WriteLine();
            WriteLine("Reading queue items after removing an item.");
            ReadingQueue(queue);
        }

       
        private void ReadingQueue(Queue queue)
        {
            foreach (var item in queue)
                WriteLine($"{item} ");
        }

        private void ReadingStack(Stack stackList)
        {
            foreach (var item in stackList)
                WriteLine($"{item} ");
        }

        private void PrintArrayListContents(ArrayList arrayList)
        {
            foreach (int arr in arrayList)
                Write(arr + " ");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExtensions
{
    public static class ListExtensions
    {
        public static Stack<T> ToStack<T>(this List<T> list)
        {
            Stack<T> stack = new Stack<T>();
            foreach (var item in list)
            {
                stack.Push(item);
            }
            return stack;
        }
    }
}

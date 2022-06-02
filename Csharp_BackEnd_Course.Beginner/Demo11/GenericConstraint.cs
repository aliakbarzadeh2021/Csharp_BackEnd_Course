using System;
using System.Collections.Generic;

namespace Day06
{
    public class GenericConstraint { }
    public class ValueTypeConstraint<T> where T : struct
    {
        public T ImplementIt(T value)
        {
            return value;
        }
    }
    public class ReferenceTypeConstraint<T> where T:class 
    {
        public T ImplementIt(T value)
        {
            return value;
        }
    }
    public class DefaultConstructorConstraint<T> where T : new()
    {
        public T ImplementIt(T value)
        {
            return value;
        }
    }

    public class BaseClassConstraint<T> where T:Person
    {
        public T ImplementIt(T value)
        {
            return value;
        }
    }
    public class InterfaceConstraint<T>:IDisposable where T : IDisposable
    {
        public T ImplementIt(T value)
        {
            return value;
        }

        public void Dispose()
        {
            //dispose stuff goes here
        }
    }
}
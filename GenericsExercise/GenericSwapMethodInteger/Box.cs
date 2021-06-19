using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodInteger
{
    public class Box<T>
    {
        public T Value { get; private set; }

        public Box(T value)
        {
            Value = value; 
        }

        public override string ToString()
        {
            Type valueType = Value.GetType();
            string valueFullName = valueType.FullName;

            return $"{valueFullName}: {Value}";
        }

    }
}

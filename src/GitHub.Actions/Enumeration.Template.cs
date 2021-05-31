using System;

namespace Janda.Base
{
    public abstract class Enumeration<T> : IComparable<T>, IEquatable<T> where T : Enumeration<T>
    {
        public int Value { get; private set; }
        public string Name { get; private set; }
        public override string ToString() => Name;

        protected Enumeration(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public bool Equals(T other)
        {
            return other.Value.Equals(Value);
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}

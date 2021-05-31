using System;

namespace Janda.Base
{
    public abstract class Enumeration : IComparable
    {
        public int Value { get; private set; }
        public string Name { get; private set; }
        public override string ToString() => Name;

        protected Enumeration(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Enumeration otherValue))
                return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public int CompareTo(object other)
        {
            return Value.CompareTo(((Enumeration)other).Value);
        }
    }
}

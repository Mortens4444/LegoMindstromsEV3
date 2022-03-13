using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.Core.Enums
{
    public abstract class EnumLikeObject<T>
    {
        protected static readonly Dictionary<byte, T> Values = new Dictionary<byte, T>();
        
        public byte Value { get; private set; }
        
        public string Name { get; private set; }

        protected EnumLikeObject(byte value, string name)
        {
            Value = value;
            Name = String.IsNullOrEmpty(name) ? value.ToString() : name;
        }

        public override string ToString()
        {
            return Name;
        }

        public static IList GetValues()
        {
            return Values.Values.ToList();
        }
    }
}

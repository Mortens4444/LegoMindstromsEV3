using System;

namespace Utils
{
    public class ComboBoxItem
    {
        public Object Object { get; }

        public ComboBoxItem(Object @object)
        {
            Object = @object;
        }

        public override string ToString()
        {
            return Object.ToString();
        }
    }
}

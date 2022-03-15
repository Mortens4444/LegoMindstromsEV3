namespace Utils
{
    public static class SByteUtils
    {
        public static void Swap(ref sbyte a, ref sbyte b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}

namespace Utils;

public static class ByteExtensions
{
    public static bool IsBitSet(this byte value, byte pattern)
    {
        return (value & pattern) == pattern;
    }
}

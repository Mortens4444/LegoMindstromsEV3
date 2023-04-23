using Mindstorms.Core.Enums;
using System.Runtime.CompilerServices;

namespace Mindstorms.Core.Extensions;

public static class ByteListExtensions
{
    public static void Append(this List<byte> bytes, string value)
    {
        bytes.AddRange(Constants.DefaultEncoding.GetBytes(value));
        bytes.Add(0);
    }

    //public static void Append(this List<byte> bytes, int value)
    //{
    //    var message = BitConverter.GetBytes(value);
    //    for (int i = 0; i < sizeof(int); i++)
    //    {
    //        bytes.Add(message[i]);
    //    }
    //}

    public static void Append<T>(this List<byte> bytes, T value) where T : struct
    {
        var message = GetMessage(value);
        for (int i = 0; i < message.Length; i++)
        {
            bytes.Add(message[i]);
        }
    }

    private static byte[] GetMessage<T>(T value) where T : struct
    {
        return typeof(T) switch
        {
            var t when t == typeof(int) => BitConverter.GetBytes(Unsafe.As<T, int>(ref value)),
            var t when t == typeof(uint) => BitConverter.GetBytes(Unsafe.As<T, uint>(ref value)),
            var t when t == typeof(short) => BitConverter.GetBytes(Unsafe.As<T, short>(ref value)),
            var t when t == typeof(ushort) => BitConverter.GetBytes(Unsafe.As<T, ushort>(ref value)),
            var t when t == typeof(float) => BitConverter.GetBytes(Unsafe.As<T, float>(ref value)),
            _ => throw new NotSupportedException()
        };
    }

    //public static void Append(this List<byte> bytes, ushort value)
    //{
    //    var message = BitConverter.GetBytes(value);
    //    bytes.Add(message[0]);
    //    bytes.Add(message[1]);
    //}

        //public static void Append(this List<byte> bytes, short value)
        //{
        //    var message = BitConverter.GetBytes(value);
        //    bytes.Add(message[0]);
        //    bytes.Add(message[1]);
        //}

        //public static void Append(this List<byte> bytes, float value)
        //{
        //    var message = BitConverter.GetBytes(value);
        //    bytes.Add(message[0]);
        //    bytes.Add(message[1]);
        //    bytes.Add(message[2]);
        //    bytes.Add(message[3]);
        //}

    public static void AppendOneBytesParameter(this List<byte> bytes, byte value)
    {
        bytes.Add(ParameterFormat.Long | FollowType.OneByte);
        bytes.Add(value);
    }

    public static void AppendTwoBytesParameter(this List<byte> bytes, byte value1, byte value2 = 0)
    {
        bytes.Add(ParameterFormat.Long | FollowType.TwoBytes);
        bytes.Add(value1);
        bytes.Add(value2);
    }

    public static void AppendTwoBytesParameter(this List<byte> bytes, ushort value)
    {
        bytes.Add(ParameterFormat.Long | FollowType.TwoBytes);
        bytes.Append(value);
    }

    public static void AppendTwoBytesParameter(this List<byte> bytes, short value)
    {
        bytes.Add(ParameterFormat.Long | FollowType.TwoBytes);
        bytes.Append(value);
    }

    public static void AppendStringParameter(this List<byte> bytes, string value)
    {
        bytes.Add(ParameterFormat.Long | FollowType.TerminatedString2);
        bytes.Append(value);
    }

    public static void AppendFourBytesParameter(this List<byte> bytes, int value)
    {
        bytes.Add(ParameterFormat.Long | FollowType.FourBytes);
        bytes.Append(value);
    }

    public static void AppendFourBytesParameter(this List<byte> bytes, float value)
    {
        bytes.Add(ParameterFormat.Long | FollowType.FourBytes);
        bytes.Append(value);
    }
}

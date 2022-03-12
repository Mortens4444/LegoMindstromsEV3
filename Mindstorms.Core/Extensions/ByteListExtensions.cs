using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Extensions
{
    public static class ByteListExtensions
    {
        public static void Append(this List<byte> bytes, string value)
        {
            bytes.AddRange(Constants.DefaultEncoding.GetBytes(value));
            bytes.Add(0);
        }

        public static void Append(this List<byte> bytes, int value)
        {
            var messageLength = BitConverter.GetBytes(value);
            bytes.Add(messageLength[0]);
            bytes.Add(messageLength[1]);
            bytes.Add(messageLength[2]);
            bytes.Add(messageLength[3]);
        }

        public static void Append(this List<byte> bytes, ushort value)
        {
            var messageLength = BitConverter.GetBytes(value);
            bytes.Add(messageLength[0]);
            bytes.Add(messageLength[1]);
        }

        public static void AppendOneBytesParameter(this List<byte> bytes, byte value)
        {
            bytes.Add((byte)ParameterFormat.Long | (byte)FollowType.OneByte);
            bytes.Add(value);
        }

        public static void AppendTwoBytesParameter(this List<byte> bytes, byte value1, byte value2 = 0)
        {
            bytes.Add((byte)ParameterFormat.Long | (byte)FollowType.TwoBytes);
            bytes.Add(value1);
            bytes.Add(value2);
        }

        public static void AppendTwoBytesParameter(this List<byte> bytes, ushort value)
        {
            bytes.Add((byte)ParameterFormat.Long | (byte)FollowType.TwoBytes);
            bytes.Append(value);
        }

        public static void AppendStringParameter(this List<byte> bytes, string value)
        {
            bytes.Add((byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2);
            bytes.Append(value);
        }
    }
}
